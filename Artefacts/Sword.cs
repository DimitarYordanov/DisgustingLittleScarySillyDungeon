using DisgustingLittleSillyScaryDungeon.Common.Enums;

namespace DisgustingLittleSillyScaryDungeon.Artefacts
{
    public class Sword : Artefact
    {
        private SwordType type;

        public Sword(SwordType type)
        {
            this.type = type;
        }

        public override int Strength
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
