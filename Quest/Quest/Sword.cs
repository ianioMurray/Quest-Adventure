using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Sword : Weapon
    {
        private const int SwordAttackRange = 1;

        public Sword(Game game, Point currentLocation) : base(game, currentLocation)
        { }

        public override string Name
        {
            get
            {
                return "Sword";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnermy(direction, SwordAttackRange, 3, random))
            {
                //try and attack clockwise from original direction
                //Direction is an enum where clockwise is always + 1
                //if the direction is left - then reset it to 0 (Up)
                int clockwise = ((int) direction) + 1;
                if((int)clockwise > (int)Direction.Left)
                {
                    clockwise = 0;
                }
                if (!DamageEnermy((Direction)clockwise, SwordAttackRange, 3, random))
                {
                    //Direction is an enum where counterclockwise is always - 1
                    //if the direction is Up - then reset it to 3 (Left)
                    int counterclockwise = ((int)direction) - 1;
                    if ((int)counterclockwise < (int)Direction.Up)
                    {
                        counterclockwise = 3;
                    }
                    DamageEnermy((Direction)counterclockwise, SwordAttackRange, 3, random);
                }
            }
        }
    }
}
