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
    public class FluffyBunny : Monster, IBunny
    {

        public FluffyBunny( 
                    int health = 25,
                    int attack = 10,
                    int defence = 5, 
                    string battlecry = "Gimmie all your carrots") 
                    : base(health, attack, defence, battlecry)
        {
            
        }
 
        public override MonsterType Type
        {
            get
            { 
                return MonsterType.FluffyBunny;
            }
        }

        public void Hide()
        {
            //Hide from the player
            //Obviously not implemented
        }
    }
}
