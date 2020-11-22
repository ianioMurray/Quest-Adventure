using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    [Serializable]

    abstract class Mover
    {
        private const int MoveInterval = 60;
        protected Point location;
        protected Game game;

        public Point Location
        {
            get
            {
                return location;
            }
        }

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            return Nearby(location, locationToCheck, distance);
        }

        public bool Nearby(Point myLocation, Point locationToCheck, int distance)
        {
            int distanceBetweenXLocations = Math.Abs(myLocation.X - locationToCheck.X);
            int distanceBetweenYLocations = Math.Abs(myLocation.Y - locationToCheck.Y);

            //return true if items locations are equal or less then the the distance measured in grid spaces apart 
            if (distanceBetweenXLocations <= distance && distanceBetweenYLocations <= distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
               
        public Point Move(Direction direction, Rectangle boundaries)
        {
            return Move(direction, location, boundaries);
        }

        public Point Move(Direction direction, Point currentLocation, Rectangle boundaries)
        {
            Point newLocation = currentLocation;

            //the switch below tries to move one the item one interval in a direction
            //if it is within the boundaries it moves to the new location, if not it returns the original location
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;
                default:
                    throw new Exception("Unknown Direction");
            }
            return newLocation;

        }
    }
}
