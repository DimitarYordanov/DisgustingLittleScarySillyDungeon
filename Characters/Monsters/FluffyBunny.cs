using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProject.Interfaces;
using GroupProject.Positioning;
using GroupProject.Common.Enums;

namespace GroupProject.Characters.Monsters
{
    public class FluffyBunny : Monster
    {

        public FluffyBunny(
                    Position position, 
                    int health = 25,
                    int maxDamage = 10,
                    int defence = 5, 
                    string battlecry = "Gimmie all your carrots") 
                    : base(health, maxDamage, position, defence, battlecry)
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
