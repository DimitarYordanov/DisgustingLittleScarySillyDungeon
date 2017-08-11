namespace DisgustingLittleSillyScaryDungeon.Common.Positioning
{
    public class Points : IPoints
    {
        private int xCoord;
        private int yCoord;

        public Points()
        {

        }

        public Points(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        public int XCoord
        {
            get
            {
                return this.xCoord;
            }

            set
            {
                this.xCoord = value;
            }
        }

        public int YCoord
        {
            get
            {
                return this.yCoord;
            }

            set
            {
                this.yCoord = value;
            }
        }
    }
}
