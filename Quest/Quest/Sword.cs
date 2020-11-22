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

        public override string Attack(Direction direction, Random random)
        {
            PlayerAttack attack = new PlayerAttack();

            attack = DamageEnermy(direction, SwordAttackRange, 3, random);

            if (!attack.successfulAttack)
            {
                //try and attack clockwise from original direction
                //Direction is an enum where clockwise is always + 1
                //if the direction is left - then reset it to 0 (Up)
                int clockwise = ((int) direction) + 1;
                if((int)clockwise > (int)Direction.Left)
                {
                    clockwise = 0;
                }
                attack = DamageEnermy((Direction)clockwise, SwordAttackRange, 3, random);

                if (!attack.successfulAttack)
                {
                    //Direction is an enum where counterclockwise is always - 1
                    //if the direction is Up - then reset it to 3 (Left)
                    int counterclockwise = ((int)direction) - 1;
                    if ((int)counterclockwise < (int)Direction.Up)
                    {
                        counterclockwise = 3;
                    }
                    attack = DamageEnermy((Direction)counterclockwise, SwordAttackRange, 3, random);
                }
            }
            return attack.attackResultDescription;
        }
    }
}
