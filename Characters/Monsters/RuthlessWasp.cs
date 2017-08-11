using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisgustingLittleSillyScaryDungeon.Contracts.Monsters;
using DisgustingLittleSillyScaryDungeon.Common.Positioning;
using DisgustingLittleSillyScaryDungeon.Common.Enums;

namespace DisgustingLittleSillyScaryDungeon.Characters.Monsters
{
    public class RuthlessWasp : Monster, IWasp
    {
        public RuthlessWasp(                    
                    int health = 35,
                    int attack = 15,
                    int defence = 7,
                    string battlecry = "BzzzZZZzzt")
            : base(health, attack, defence, battlecry)
        {

        }

        public override MonsterType Type
        {
            get
            {
                return MonsterType.RuthlessWasp;
            }
        }

        public void Sting()
        {
            //Special attack
            //Obviously not implemented
        }
    }
}
