using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest
{
    public enum Direction
    {
        Up = 0,
        Right = 1,
        Down = 2,
        Left = 3
    }


    public partial class Form1 : Form
    {
        Game game;
        Random random = new Random();

        private bool moveUpButtonDown = false;
        private bool moveRightButtonDown = false;
        private bool moveDownButtonDown = false;
        private bool moveLeftButtonDown = false;

        private bool attackUpButtonDown = false;
        private bool attackRightButtonDown = false;
        private bool attackDownButtonDown = false;
        private bool attackLeftButtonDown = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(120, 80, 720, 240));
            game.NewLevel(random);
            UpdateCharacters();
        }

        //Move in a dirction around the screen
        private void MoveCharacter(Direction direction)
        {
            game.Move(direction, random);
            UpdateCharacters();
        }

        //attack in a direction around the screen
        private void CharacterAttack(Direction direction)
        {
            game.Attack(direction, random);
            UpdateCharacters();
        }

        //Update the UI with weapons/characters/enermies 
        private void UpdateCharacters()
        {
            UpdatePlayerUI();
            int enermiesShown = UpdateEnermyUI();
            UpdateWeaponUI();
 

            if(game.PlayerHitPoints <= 0 )
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if(enermiesShown < 1)
            {
                MessageBox.Show("you have defeated the enermies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        private void UpdatePlayerUI()
        {
            //player image location and Hit Points 
            PlayerImage.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
        }

        private int UpdateEnermyUI()
        {
            //Goes through enermies making them visible or not and showing other details about them
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enermiesShown = 0;

            foreach (Enermy enermy in game.Enermies)
            {
                if (enermy is Bat)
                {
                    BatImage.Location = enermy.Location;
                    batHitPoints.Text = enermy.HitPoints.ToString();
                    if (enermy.HitPoints > 0)
                    {
                        showBat = true;
                        enermiesShown++;
                    }
                }
                else if (enermy is Ghost)
                {
                    GhostImage.Location = enermy.Location;
                    ghostHitPoints.Text = enermy.HitPoints.ToString();
                    if (enermy.HitPoints > 0)
                    {
                        showGhost = true;
                        enermiesShown++;
                    }
                }
                else
                {
                    GhoulImage.Location = enermy.Location;
                    ghoulHitPoints.Text = enermy.HitPoints.ToString();
                    if (enermy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enermiesShown++;
                    }
                }
            }

            if (!showBat)
            {
                BatImage.Visible = false;
                batHitPoints.Text = "N/A";
            }
            else
            {
                BatImage.Visible = true;
            }

            if (!showGhost)
            {
                GhostImage.Visible = false;
                ghostHitPoints.Text = "N/A";
            }
            else
            {
                GhostImage.Visible = true;
            }

            if (!showGhoul)
            {
                GhoulImage.Visible = false;
                ghoulHitPoints.Text = "N/A";
            }
            else
            {
                GhoulImage.Visible = true;
            }

            return enermiesShown;
        }

        private void UpdateWeaponUI()
        {
            SwordImage.Visible = false;
            MaceImage.Visible = false;
            BowImage.Visible = false;
            RedPotionImage.Visible = false;
            BluePotionImage.Visible = false;

            //choose which weapon will appear on this level
            Control weaponControl = null;

            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = SwordImage;
                    break;
                case "Mace":
                    weaponControl = MaceImage;
                    break;
                case "Bow":
                    weaponControl = BowImage;
                    break;
                case "Red Potion":
                    weaponControl = RedPotionImage;
                    break;
                case "Blue Potion":
                    weaponControl = BluePotionImage;
                    break;
                default:
                    throw new Exception("Unknown weapon type");
            }

            //make the weapon visible in the game grid unless it has been picked up
            weaponControl.Location = game.WeaponInRoom.Location;

            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
            {
                weaponControl.Visible = true;
            }

            //Update the inventory so that the weapons the player has appear or those they dont do not appear
            UpdateInventoryWithVisibleWeapon("Sword", inventorySword);
            UpdateInventoryWithVisibleWeapon("Mace", inventoryMace);
            UpdateInventoryWithVisibleWeapon("Bow", inventoryBow);
            UpdateInventoryWithVisibleWeapon("Red Potion", inventoryRedPotion);
            UpdateInventoryWithVisibleWeapon("Blue Potion", inventoryBluePotion);

            //if the player has only 1 weapon in their inventory equip it automatically
            List<string> weapons = (List<string>)game.PlayerWeapons;

            if (weapons.Count == 1)
            {
                EquipInventoryItem(weapons[0]);
            }
        }

        private void UpdateInventoryWithVisibleWeapon(string weaponName, Control inventoryImage)
        {
            if (game.CheckPlayerInventory(weaponName))
            {
                inventoryImage.Visible = true;
            }
            else
            {
                inventoryImage.Visible = false;
            }
        }

        //Equip the selected weapon held in the inventory
        private void EquipInventoryItem(string weaponName)
        {
            if (game.CheckPlayerInventory(weaponName))
            {
                game.Equip(weaponName);
                SetWeaponBorderStyle(weaponName);
            }
        }




        //Decides what the border should look like for a weapon in the inventory 
        //and changes attack arrows if weapon is a potion 
        private void SetWeaponBorderStyle(string weapon)
        {
            RemoveInventoryBorderStyle();
            MakeAttackButtonsVisible();

            switch (weapon)
            {
                case "Sword":

                    inventorySword.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "Mace":
                    inventoryMace.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "Bow":
                    inventoryBow.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "Red Potion":
                    inventoryRedPotion.BorderStyle = BorderStyle.FixedSingle;
                    AttackButtonsUpdateDueToPotionEquipped();
                    break;
                case "Blue Potion":
                    inventoryBluePotion.BorderStyle = BorderStyle.FixedSingle;
                    AttackButtonsUpdateDueToPotionEquipped();
                    break;
                default:
                    throw new Exception("Inventory Border Style Exeception - No such weapon");
            }
        }

        private void RemoveInventoryBorderStyle()
        {
            inventorySword.BorderStyle = BorderStyle.None;
            inventoryMace.BorderStyle = BorderStyle.None;
            inventoryBow.BorderStyle = BorderStyle.None;
            inventoryRedPotion.BorderStyle = BorderStyle.None;
            inventoryBluePotion.BorderStyle = BorderStyle.None;
        }

        private void MakeAttackButtonsVisible()
        {
            attackUpButton.Visible = true;
            attackRightButton.Visible = true;
            attackDownButton.Visible = true;
            attackLeftButton.Visible = true;

            attackUpButton.Font = new Font("Microsoft Sans Serif",12);
            attackUpButton.Text = "↑";
        }

        private void AttackButtonsUpdateDueToPotionEquipped()
        {
            attackUpButton.Visible = true;
            attackRightButton.Visible = false;
            attackDownButton.Visible = false;
            attackLeftButton.Visible = false;

            attackUpButton.Font = new Font("Microsoft Sans Serif", 8);
            attackUpButton.Text = "Drink";
        }

        //handles actions when MOVE arrow selected 
        private void moveUpButton_Click(object sender, EventArgs e)
        {
            MoveCharacter(Direction.Up);
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            MoveCharacter(Direction.Right);
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            MoveCharacter(Direction.Down);
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            MoveCharacter(Direction.Left);
        }


        //handles actions when ATTACT control selected
        private void attackUpButton_Click(object sender, EventArgs e)
        {
            CharacterAttack(Direction.Up);
        }

        private void attackRightButton_Click(object sender, EventArgs e)
        {
            CharacterAttack(Direction.Right);
        }

        private void attackDownButton_Click(object sender, EventArgs e)
        {
            CharacterAttack(Direction.Down);
        }

        private void attackLeftButton_Click(object sender, EventArgs e)
        {
            CharacterAttack(Direction.Left);
        }

        //handles action when WEAPON in INVENTORY is selected 
        private void inventorySword_DoubleClick(object sender, EventArgs e)
        {
            EquipInventoryItem("Sword");
        }

        private void inventoryMace_DoubleClick(object sender, EventArgs e)
        {
            EquipInventoryItem("Mace");
        }

        private void inventoryBow_DoubleClick(object sender, EventArgs e)
        {
            EquipInventoryItem("Bow");
        }

        private void inventoryBluePotion_DoubleClick(object sender, EventArgs e)
        {
            EquipInventoryItem("Blue Potion");
        }

        private void inventoryRedPotion_DoubleClick(object sender, EventArgs e)
        {
            EquipInventoryItem("Red Potion");
        }


        //HANDLES UI STYLING

        //Making the move / attack buttons 3D
        private void buttonDown(object sender)
        {
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void buttonPaint(object sender, PaintEventArgs e, bool buttonDown)
        {
            if (buttonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        //Attack buttons Appearance

        //attack up
        private void attackUpButton_Paint(object sender, PaintEventArgs e)
        {
            buttonPaint(sender, e, attackUpButtonDown);
        }

        private void attackUpButton_MouseDown(object sender, MouseEventArgs e)
        {
            attackUpButtonDown = true;
            buttonDown(sender);
        }

        private void attackUpButton_MouseUp(object sender, MouseEventArgs e)
        {
            attackUpButtonDown = false;
            buttonDown(sender);
        }

        //attack right
        private void attackRightButton_Paint(object sender, PaintEventArgs e)
        {
            buttonPaint(sender, e, attackRightButtonDown);
        }

        private void attackRightButton_MouseDown(object sender, MouseEventArgs e)
        {
            attackRightButtonDown = true;
            buttonDown(sender);
        }

        private void attackRightButton_MouseUp(object sender, MouseEventArgs e)
        {
            attackRightButtonDown = false;
            buttonDown(sender);
        }

        //attack down
        private void attackDownButton_Paint(object sender, PaintEventArgs e)
        {
            buttonPaint(sender, e, attackDownButtonDown);
        }

        private void attackDownButton_MouseDown(object sender, MouseEventArgs e)
        {
            attackDownButtonDown = true;
            buttonDown(sender);
        }

        private void attackDownButton_MouseUp(object sender, MouseEventArgs e)
        {
            attackDownButtonDown = false;
            buttonDown(sender);
        }

        //attack left 
        private void attackLeftButton_Paint(object sender, PaintEventArgs e)
        {
            buttonPaint(sender, e, attackLeftButtonDown);
        }

        private void attackLeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            attackLeftButtonDown = true;
            buttonDown(sender);
        }

        private void attackLeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            attackLeftButtonDown = false;
            buttonDown(sender);
        }


        //Move Buttons Appearance

        //move up
        private void moveUpButton_Paint(object sender, PaintEventArgs e)
        {
            buttonPaint(sender, e, moveUpButtonDown);
        }

        private void moveUpButton_MouseDown(object sender, MouseEventArgs e)
        {
            moveUpButtonDown = true;
            buttonDown(sender);
        }

        private void moveUpButton_MouseUp(object sender, MouseEventArgs e)
        {
            moveUpButtonDown = false;
            buttonDown(sender);
        }

        //move right
        private void moveRightButton_Paint(object sender, PaintEventArgs e)
        {
            buttonPaint(sender, e, moveRightButtonDown);
        }

        private void moveRightButton_MouseDown(object sender, MouseEventArgs e)
        {
            moveRightButtonDown = true;
            buttonDown(sender);
        }

        private void moveRightButton_MouseUp(object sender, MouseEventArgs e)
        {
            moveRightButtonDown = false;
            buttonDown(sender);
        }

        //move down
        private void moveDownButton_Paint(object sender, PaintEventArgs e)
        {
            buttonPaint(sender, e, moveDownButtonDown);
        }

        private void moveDownButton_MouseDown(object sender, MouseEventArgs e)
        {
            moveDownButtonDown = true;
            buttonDown(sender);
        }

        private void moveDownButton_MouseUp(object sender, MouseEventArgs e)
        {
            moveDownButtonDown = false;
            buttonDown(sender);
        }

        //move left 
        private void moveLeftButton_Paint(object sender, PaintEventArgs e)
        {
            buttonPaint(sender, e, moveLeftButtonDown);
        }

        private void moveLeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            moveLeftButtonDown = true;
            buttonDown(sender);
        }

        private void moveLeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            moveLeftButtonDown = false;
            buttonDown(sender);
        }
    }
}
