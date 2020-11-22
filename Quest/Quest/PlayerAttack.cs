using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    class PlayerAttack
    {
        private bool SuccessfulAttack = false;
        private string AttackResultDescription = "";

        public bool successfulAttack
        {
            get
            {
                return SuccessfulAttack;
            }
            set
            {
                SuccessfulAttack = value;
            }
        }

        public string attackResultDescription
        {
            get
            {
                return AttackResultDescription;
            }
            set
            {
                AttackResultDescription = value;
            }
        }
    }
}
