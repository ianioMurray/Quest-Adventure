﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{

    class Mace : Weapon
    {
        private const int MaceAttackRange = 2;


        public Mace(Game game, Point currentLocation) : base(game, currentLocation)
        { }

        public override string Name
        {
            get
            {
                return "Mace";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            int possibleAttackDirections = 4;
            Direction attackDirection = direction;

            for (int i = 0; i < possibleAttackDirections; i++)
            {
                if(DamageEnermy(attackDirection, MaceAttackRange, 6, random))
                {
                    break;
                }
                else
                {
                    int nextAttackDirection = (int)attackDirection + 1;
                    if(nextAttackDirection > (int)Direction.Left)
                    {
                        attackDirection = Direction.Up;
                    }
                    else
                    {
                        attackDirection = (Direction)nextAttackDirection;
                    }
                }
            }
        }
    }
}