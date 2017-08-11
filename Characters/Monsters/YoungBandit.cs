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
    public class YoungBandit : Monster, IBandit
    {
        public YoungBandit(
                    int health = 45,
                    int attack = 20,
                    int defence = 10,
                    string battlecry = "Your gold is mine, pup!")
            : base(health, attack, defence, battlecry)
        {

        }

        public override MonsterType Type
        {
            get
            {
                return MonsterType.YoungBandit;
            }
        }

        public void GoldSteal()
        {
            //steal Player's gold
            //Obviously not impremented
        }
    }
}
