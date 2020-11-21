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

        public Ghoul(Game game, Point currentLocation) : base(game, currentLocation, 10)
        { }

        public override void Move(Random random)
        {
            if(!Dead)
            {
                //66% the Ghoul moves towards the player & 33% it does not move
                if (random.Next(3) < 2)
                {
                    Direction directionToMove = base.FindPlayerDirection(game.PlayerLocation);
                    base.location = base.Move(directionToMove, game.Bourdaries);
                }

                if (NearPlayer(attackRange, random))
                {
                    game.HitPlayer(4, random);
                }
            }
        }
    }
}
