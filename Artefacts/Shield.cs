using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Artefacts
{
    public class Shield : Artefact
    {
        public Shield(int xCoord, int yCoord) : base(xCoord, yCoord)
        {
        }

        public override int Strentgh
        {
            get
            {
                return 0;
            }
            set
            {
            }
        }
        public override int Agility
        {
            get
            {
                return 30;
            }
            set
            {

            }
        }
        public override int Intelligence
        {
            get
            {
                return 15;
            }
            set
            {

            }
        }
    }
}
