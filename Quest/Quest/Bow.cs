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

        public override string Attack(Direction direction, Random random)
        {
            PlayerAttack attack = new PlayerAttack();
            attack = DamageEnermy(direction, BowAttackRange, 1, random);
            return attack.attackResultDescription;
        }
    }
}
