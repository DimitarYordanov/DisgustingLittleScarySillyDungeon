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
    public class RuthlessWasp : Monster
    {
        public RuthlessWasp(
                    Position position,
                    int health = 35,
                    int maxDamage = 15,
                    int defence = 7,
                    string battlecry = "BzzzZZZzzt")
            : base(health, maxDamage, position, defence, battlecry)
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
