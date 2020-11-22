using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Ghoul : Enermy
    {
        private int attackRange = 1;

        public override string Name
        {
            get
            {
                return "ghoul";
            }
        }

        public Ghoul(Game game, Point currentLocation) : base(game, currentLocation, 10)
        { }

        public override string Move(Random random)
        {
            string output = "";
            if(!Dead)
            {
                //66% the Ghoul moves towards the player & 33% it does not move
                if (random.Next(3) < 2)
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
                    int damage = game.HitPlayer(4, random);
                    output += "The " + Name + " hit the player for " + damage + " points of damage" + Environment.NewLine;
                }
            }
            return output;
        }
    }
}
