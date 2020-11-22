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

        abstract public string Name
        {
            get;
        }

        public Enermy(Game game, Point location, int hitPoints): base(game, location)
        {
            HitPoints = hitPoints;
        }

        abstract public string Move(Random random);

        public string Hit(int maxDamage, Random random)
        {
            int damage = (random.Next(maxDamage) + 1);
            HitPoints = HitPoints - damage;
            return "The player inflicted " + damage + " points of damage to the " + Name + Environment.NewLine; 
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

        protected string GenerateTextOutputForTheMove(Point newLocation, Point previousLocaiton, Direction directionToMove)
        {
            string output = "";
            if (Nearby(newLocation, previousLocaiton, 0))
            {
                output = "The " + Name + " was unable to move" + Environment.NewLine;
            }
            else
            {
                output = "The " + Name + " moved " + directionToMove.ToString() + Environment.NewLine;
            }
            return output;
        }
    }
}
