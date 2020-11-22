using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    [Serializable]

    class BluePotion : Weapon, IPotion
    {
        public bool Used { get; private set; }

        public BluePotion(Game game, Point currentLocation) : base(game, currentLocation)
        {
            Used = false;
        }

        public override string Name
        {
            get
            {
                return "Blue Potion";
            }
        }

        public override string Attack(Direction direction, Random random)
        {
            Used = true;
            return game.IncreasePlayerHealth(5, random);
        }
    }
}
