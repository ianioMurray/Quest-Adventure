using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Ghost : Enermy
    {
        private int attackRange = 1;

        public override string Name
        {
            get
            {
                return "ghost";
            }
        }

        public Ghost(Game game, Point currentLocation) : base(game, currentLocation, 8)
        { }

        public override string Move(Random random)
        {
            string output = "";
            if(!Dead)
            {
                //33% the Ghost moves towards the player & 66% it does not move
                if (random.Next(3) == 0)
                {
                    Point tempLocation = base.location;
                    Direction directionToMove = base.FindPlayerDirection(game.PlayerLocation);
                    base.location = base.Move(directionToMove, game.Bourdaries);
                    output += GenerateTextOutputForTheMove(base.location, tempLocation, directionToMove);
                }
                else
                {
                    output += "The " + Name + " did not attempt to move" + Environment.NewLine;
                }

                if (NearPlayer(attackRange, random))
                {
                    int damage = game.HitPlayer(3, random);
                    output += "The " + Name + " hit the player for " + damage + " points of damage" + Environment.NewLine;
                }
            }
            return output;
        }
    }
}
