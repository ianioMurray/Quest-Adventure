using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Bow : Weapon
    {
        private const int BowAttackRange = 3;

        public Bow(Game game, Point currentLocation) : base(game, currentLocation)
        { }

        public override string Name
        {
            get
            {
                return "Bow";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnermy(direction, BowAttackRange, 1, random);
        }
    }
}
