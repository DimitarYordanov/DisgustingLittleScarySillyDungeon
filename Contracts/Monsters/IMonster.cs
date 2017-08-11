using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisgustingLittleSillyScaryDungeon.Common.Positioning;
using DisgustingLittleSillyScaryDungeon.Common.Enums;
using DisgustingLittleSillyScaryDungeon.Contracts;
using DisgustingLittleSillyScaryDungeon.Contracts.PlayerCharacters;

namespace DisgustingLittleSillyScaryDungeon.Contracts.Monsters
{
    public interface IMonster : ICharacter
    {
        Points Position { get; set; }
        string Battlecry { get; set; }

        void AttackMove(IHero target);

    }
}
