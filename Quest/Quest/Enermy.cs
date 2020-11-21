using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    abstract class Enermy : Mover
    {
        public int HitPoints { get; private set; }
        public bool Dead
        {
            get
            {
                if(HitPoints <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Enermy(Game game, Point location, int hitPoints): base(game, location)
        {
            HitPoints = hitPoints;
        }

        abstract public void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            HitPoints = HitPoints - (random.Next(maxDamage) + 1);
        }

        protected bool NearPlayer(int attackRange, Random random)
        {
            //loop checks if the locations are the same, if not it sets the temp variable to location 1 move from the 
            //original location and checks if they are the same.  It does this till the range is met. Once the max range 
            //is reached the temp variable is set back to the enermies location and the next direction is checked till its max
            //range.  Each direction is then checked in turn to the max range
            for (int i = 0; i < Enum.GetValues(typeof(Direction)).Length; i++)
            {
                Point tempLocation = Location;

                for (int distance = 0; distance <= attackRange; distance++)
                {
                    if (Nearby(tempLocation, game.PlayerLocation, distance))
                    {
                        return true;
                    }
                    tempLocation = Move((Direction)i, tempLocation, game.Bourdaries);
                }
            }
            return false;
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;

            if(playerLocation.X > location.X + 10)
            {
                directionToMove = Direction.Right;
            }
            else if (playerLocation.X < location.X - 10)
            {
                directionToMove = Direction.Left;
            }
            else if (playerLocation.Y > location.Y + 10)
            {
                directionToMove = Direction.Down;
            }
            else
            {
                directionToMove = Direction.Up;
            }
            return directionToMove;
        }
    }
}
