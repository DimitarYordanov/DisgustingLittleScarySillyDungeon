using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Positioning
{
    public struct Position
    {
        public Position (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}", this.X, this.Y);
        }
    }
}
