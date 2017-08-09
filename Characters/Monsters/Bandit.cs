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
    public class Bandit : Monster
    {
        public Bandit(
                    Position position,
                    int health = 45,
                    int maxDamage = 20,
                    int defence = 10,
                    string battlecry = "Your gold is mine, pup!")
            : base(health, maxDamage, position, defence, battlecry)
        {

        }

        public override MonsterType Type
        {
            get
            {
                return MonsterType.Bandit;
            }
        }
        
        public void Scare()
        {

        }
    }
}
