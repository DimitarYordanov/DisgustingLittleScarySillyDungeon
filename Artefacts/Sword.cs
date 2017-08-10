using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Artefacts
{
    public class Sword : Artefact
    {
        private SwordType type;

        public Sword(SwordType type)
        {
            this.type = type;
        }

        public override int Strentgh
        {
            get
            {
                return 10 * (int)type;
            }
            set
            {

            }
        }
        public override int Agility
        {
            get
            {
                return (int)type;
            }
            set
            {
            }
        }
        public override int Intelligence
        {
            get
            {
                return 1;
            }

            set
            {

            }
        }
    }
}
