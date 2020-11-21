using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
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
            HitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            int damage = random.Next(maxDamage) + 1;
            HitPoints = HitPoints - damage;
        }

        public void IncreaseHealth(int health, Random random)
        {
            int healedDamage = random.Next(health) + 1;
            HitPoints = HitPoints + healedDamage;
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

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Bourdaries);
            if(!game.WeaponInRoom.PickedUp)
            {
                if(Nearby(game.WeaponInRoom.Location, StandingOnWeapon))
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                    if(inventory.Count == 1)
                    {
                        Equip(game.WeaponInRoom.Name);
                    }
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if(equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);

                //if the weapon is a potion it is removed from the inventory
                if(equippedWeapon is IPotion)
                {
                    inventory.Remove(equippedWeapon);
                    equippedWeapon = null;
                }
            }
        }
    }
}
