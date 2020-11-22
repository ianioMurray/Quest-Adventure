using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    [Serializable]

    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location) : base(game, location)
        {
            PickedUp = false;
        }
                
        public void PickUpWeapon()
        {
            PickedUp = true;
        }

        public abstract string Name { get; }

        public abstract string Attack(Direction direction, Random random);

        protected PlayerAttack DamageEnermy(Direction direction, int range, int damage, Random random)
        {
            PlayerAttack attack = new PlayerAttack();
            //creates a temp variable that stores the players position
            Point tempPlayerLocation = game.PlayerLocation;
            //loop to see if the enermy is in range to attack.  distance = 0 will check if the player 
            //and monster is on the same location.  If they are not the temp player variable will be 
            //set to be one location in the direction of the attack and then the loop will see if the monster and the temp location
            //are the same.
            for (int distance = 0; distance <= range; distance++)
            {
                foreach(Enermy enermy in game.Enermies)
                {
                    if(Nearby(tempPlayerLocation, enermy.Location, distance))
                    {
                        attack.attackResultDescription = enermy.Hit(damage, random);
                        attack.successfulAttack = true;
                        return attack;
                    }
                }
                //this move() does not move the player it simply stores the location one move in the direction of the attack 
                tempPlayerLocation = Move(direction, tempPlayerLocation, game.Bourdaries);
            }
            return attack;
        }
    }
}
