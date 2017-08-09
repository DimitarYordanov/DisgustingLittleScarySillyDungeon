using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Artefacts
{
    class Hammer : Artefact
    {
        public Hammer(int xCoord, int yCoord) : base(xCoord, yCoord)
        {
        }

        public override int Strentgh
        {
            get
            {
                return 25;
            }
            set
            {
            }
        }

        public override int Agility
        {
            get
            {
                return 10;
            }
            set
            {
            }
        }

        public override int Intelligence
        {
            get
            {
                return 5;
            }
            set
            {

            }
        }
    }
}
