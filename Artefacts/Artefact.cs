using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Artefacts
{
    public abstract class Artefact
    {
        //Removed Constructors in all classes, since it was the default one anyway
        public abstract int Strength
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
