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
    public class FluffyBunny : Monster
    {

        public FluffyBunny( 
                    int health = 25,
                    int maxDamage = 10,
                    int defence = 5, 
                    string battlecry = "Gimmie all your carrots") 
                    : base(health, maxDamage, defence, battlecry)
        {
            
        }
 
        public override MonsterType Type
        {
            get
            { 
                return MonsterType.FluffyBunny;
            }
        }
    }
}
