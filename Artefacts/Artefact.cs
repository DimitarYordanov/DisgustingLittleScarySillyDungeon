using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Artefacts
{
    public abstract class Artefact
    {
        public Artefact ()
        {

        }

        public abstract int Strentgh
        {
            get;
            set;
        }

        public abstract int Agility
        {
            get;
            set;
        }

        public abstract int Intelligence
        {
            get;
            set;
        }
    }
}
