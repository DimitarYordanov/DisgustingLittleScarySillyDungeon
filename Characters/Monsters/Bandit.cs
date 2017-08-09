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
