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

        public Ghost(Game game, Point currentLocation) : base(game, currentLocation, 8)
        { }

        public override void Move(Random random)
        {
            if(!Dead)
            {
                //33% the Ghost moves towards the player & 66% it does not move
                if (random.Next(3) == 0)
                {
                    Direction directionToMove = base.FindPlayerDirection(game.PlayerLocation);
                    base.location = base.Move(directionToMove, game.Bourdaries);
                }

                if (NearPlayer(attackRange, random))
                {
                    game.HitPlayer(3, random);
                }
            }
        }
    }
}
