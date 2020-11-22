using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    [Serializable]

    class Bat : Enermy
    {
        private int attackRange = 1;

        public Bat(Game game, Point currentLocation) :base(game, currentLocation, 6)
        { }

        public override string Name
        {
            get
            {
                return "bat";
            }
        }

        public override string Move(Random random)
        {
            string output = "";
            if (!Dead)
            {
                Point tempLocation = base.location;
                Direction directionToMove;
                //50% the bat moves towards the player & 50% moves randomly
                if (random.Next(2) == 0)
                {
                    directionToMove = base.FindPlayerDirection(game.PlayerLocation);
                }
                else
                {
                    directionToMove = (Direction)random.Next(Enum.GetValues(typeof(Direction)).Length);
                }

                base.location = base.Move(directionToMove, game.Bourdaries);
                output += GenerateTextOutputForTheMove(base.location, tempLocation, directionToMove);

                if (NearPlayer(attackRange, random))
                {
                    int damage = game.HitPlayer(2, random);
                    output += "The " + Name + " hit the player for " + damage + " points of damage" + Environment.NewLine;
                }
            }
            return output;
        }
    }
}
