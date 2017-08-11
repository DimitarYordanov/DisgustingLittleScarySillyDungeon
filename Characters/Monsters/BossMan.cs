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
    public class BossMan : Monster, IBoss
    {

        public BossMan(
                int health = 76,
                int attack = 25,
                int defense = 10,
                string battlecry = "You defeated all the stupid ones, now you face ME!")
                : base(health, attack, defense, battlecry)
        {

        }

        public override MonsterType Type
        {
            get
            {
                return MonsterType.BossMan;
            }
        }

        public void Scare()
        {
            //Scare the player
            //Obviously not implemented
        }

    }
}
