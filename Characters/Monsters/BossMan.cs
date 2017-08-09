using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisgustingLittleSillyScaryDungeon.Interfaces;
using DisgustingLittleSillyScaryDungeon.Positioning;
using DisgustingLittleSillyScaryDungeon.Common.Enums;

namespace DisgustingLittleSillyScaryDungeon.Characters.Monsters
{
    public class BossMan : Monster
    {

        public BossMan(
                Position position,
                int health = 76,
                int maxDamage = 25,
                int defence = 10,
                string battlecry = "You defeated all the stupid ones, now you face ME!")
                : base(health, maxDamage, position, defence, battlecry)
        {

        }

        public override MonsterType Type
        {
            get
            {
                return MonsterType.BossMan;
            }
        }

        public override string ToString()
        {
            return string.Format("Fluffy Bunny\nHealth: {0}\nDamage: {1}\nDefence: {2}\nPlace: {3}\nBattlecry: {4}",
                this.Health, this.MaxDamage, this.Defence, this.Position, this.Battlecry);
        }
    }
}
