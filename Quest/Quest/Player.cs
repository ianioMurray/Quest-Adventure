using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    [Serializable]

    class Player : Mover
    {
        private Weapon equippedWeapon;
        //StandingOnWeapon is the max distance the weapon and player can be apart for the player to pick up it up 
        private const int StandingOnWeapon = 0;

        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>(); 

        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach(Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
        }
       
        public Player(Game game, Point location) : base(game, location)
        {
            HitPoints = 30;
        }

        public int Hit(int maxDamage, Random random)
        {
            int damage = random.Next(maxDamage) + 1;
            HitPoints = HitPoints - damage;
            return damage;
        }

        public string IncreaseHealth(int health, Random random)
        {
            int healedDamage = random.Next(health) + 1;
            HitPoints = HitPoints + healedDamage;
            return "The player healed themselves " + healedDamage + " points of damage" + Environment.NewLine;
        }

        public void Equip(string weaponName)
        {
            foreach(Weapon weapon in inventory)
            {
                if(weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public string Move(Direction direction)
        {
            string output = "";

            Point tempLocation = base.location;
            base.location = Move(direction, game.Bourdaries);

            if(Nearby(tempLocation, base.location, 0))
            {
                output = "The player was unable to move" + Environment.NewLine;
            }
            else
            {
                output = "The player moved " + direction.ToString() + Environment.NewLine;
            }

            if(!game.WeaponInRoom.PickedUp)
            {
                if(Nearby(game.WeaponInRoom.Location, StandingOnWeapon))
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                    output += "The player picked up the " + game.WeaponInRoom.Name + Environment.NewLine;
                    if(inventory.Count == 1)
                    {
                        Equip(game.WeaponInRoom.Name);
                    }
                }
            }
            return output;
        }

        public string Attack(Direction direction, Random random)
        {
            string output = "";
            if(equippedWeapon != null)
            {
                output += equippedWeapon.Attack(direction, random);

                //if the weapon is a potion it is removed from the inventory
                if(equippedWeapon is IPotion)
                {
                    inventory.Remove(equippedWeapon);
                    equippedWeapon = null;
                }
            }
            else
            {
                output += "The player does not have a weapon equipped" + Environment.NewLine;
            }
            return output;
        }

        public void SetPlayerForLevelStart(Point location)
        {
            base.location = location;
        }
    }
}
