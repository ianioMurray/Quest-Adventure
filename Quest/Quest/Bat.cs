using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Bat : Enermy
    {
        private int attackRange = 1;

        public Bat(Game game, Point currentLocation) :base(game, currentLocation, 6)
        { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
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

                if (NearPlayer(attackRange, random))
                {
                    game.HitPlayer(2, random);
                }
            }
        }
    }
}
