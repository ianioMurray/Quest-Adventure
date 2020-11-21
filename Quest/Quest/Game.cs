using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Game
    {
        public IEnumerable<Enermy> Enermies { get; private set; } 
        public Weapon WeaponInRoom { get; private set; }

        private Player player;
        public Point PlayerLocation
        {
            get
            {
                return player.Location;
            }
        }

        public int PlayerHitPoints
        {
            get
            {
                return player.HitPoints;
            }
        }

        public IEnumerable<string> PlayerWeapons
        {
            get
            {
                return player.Weapons;
            }
        }

        private int level = 0;

        public int Level
        {
            get
            {
                return level;
            }
        }

        private Rectangle boundaries;

        public Rectangle Bourdaries
        {
            get
            {
                return boundaries;
            }
        }


        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left, boundaries.Top + 120));
        }

        public void Move(Direction direction, Random  random)
        {
            player.Move(direction);

            foreach(Enermy enermy in Enermies)
            {
                enermy.Move(random);
            }
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);    
            foreach(Enermy enermy in Enermies)
            {
                enermy.Move(random);
            }
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + (random.Next(13) * 60), boundaries.Top + (random.Next(5) * 60));
        }

        public void NewLevel(Random random)
        {
            level++;
            List<string> monsters = new List<string>();
            List<string> weapons = new List<string>();

            switch (level)
            {
                case 1:
                    monsters.Add("Bat");
                    weapons.Add("Sword");
                    break;
                case 2:
                    monsters.Add("Ghost" );
                    weapons.Add("BluePotion");

                    break;
                case 3:
                    monsters.Add("Ghoul");
                    weapons.Add("Bow");
                    break;
                case 4:
                    monsters.Add("Bat");
                    monsters.Add("Ghost");
                    weapons.Add("Bow");
                    weapons.Add("BluePotion");
                    break;
                case 5:
                    monsters.Add("Bat");
                    monsters.Add("Ghoul");
                    weapons.Add("RedPotion");
                    break;
                case 6:
                    monsters.Add("Ghost");
                    monsters.Add("Ghoul");
                    weapons.Add("Mace");
                    break;
                case 7:
                    monsters.Add("Bat");
                    monsters.Add("Ghost");
                    monsters.Add("Ghoul");
                    weapons.Add("Mace");
                    weapons.Add("RedPotion");
                    break;
                default:
                    //need to end the game with Allocation.Exit();
                    break;

            }
            SetMonsterInRoom(monsters, random);
            SetWeapon(weapons, random);
        }

        public void SetMonsterInRoom(IEnumerable<string> monsters, Random random)
        {
            List<Enermy> tempEnermies = new List<Enermy>();
            foreach(string monster in monsters)
            {
                switch(monster)
                {
                    case "Bat":
                        tempEnermies.Add(new Bat(this, new Point(boundaries.Left + 60, boundaries.Top + 120))); //GetRandomLocation(random)));
                        break;
                    case "Ghost":
                        tempEnermies.Add(new Ghost(this, GetRandomLocation(random)));
                        break;
                    case "Ghoul":
                        tempEnermies.Add(new Ghoul(this, GetRandomLocation(random)));
                        break;
                    default:
                        throw new Exception("Unknown Monster Expection");
                }
            }
            Enermies = tempEnermies;
        }

        //function takes a list of possible weapons 
        //  if the character does not have the first weapon in the list it is added into the room
        //  if they do then it is ignored and the second weapon is tried etc.  
        //  if they have all the weapons - the weapon in the room is null
        public void SetWeapon(IEnumerable<string> weapons, Random random)
        {
            foreach(string weapon in weapons)
            {
                if (!CheckPlayerInventory(weapon))
                {
                    switch(weapon)
                    {
                        case "Sword":
                            WeaponInRoom = new Sword(this, GetRandomLocation(random));
                            return;
                        case "Mace":
                            WeaponInRoom = new Mace(this, GetRandomLocation(random));
                            return;
                        case "Bow":
                            WeaponInRoom = new Bow(this, GetRandomLocation(random));
                            return;
                        case "BluePotion":
                            WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                            return;
                        case "RedPotion":
                            WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                            return;
                        default:
                            throw new Exception("Unknown weapon type");
                    }
                }
            }
            WeaponInRoom = null;
        }
    }
}
