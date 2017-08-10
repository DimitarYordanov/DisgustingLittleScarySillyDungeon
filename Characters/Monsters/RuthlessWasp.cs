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
    public class RuthlessWasp : Monster
    {
        public RuthlessWasp(                    
                    int health = 35,
                    int maxDamage = 15,
                    int defence = 7,
                    string battlecry = "BzzzZZZzzt")
            : base(health, maxDamage, defence, battlecry)
        {

        }

        public override MonsterType Type
        {
            get
            {
                return MonsterType.RuthlessWasp;
            }
        }
    }
}
