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
        private int xCoord;
        private int yCoord;

        public Sword(int xCoord, int yCoord, SwordType type) : base(xCoord, yCoord)
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
                return 0;
            }

            set
            {

            }
        }
    }
}
