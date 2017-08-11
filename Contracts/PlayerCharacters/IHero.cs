using DisgustingLittleSillyScaryDungeon.Artefacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisgustingLittleSillyScaryDungeon.Contracts;

namespace DisgustingLittleSillyScaryDungeon.Contracts.PlayerCharacters
{
    public interface IHero : ICharacter
    {
        void GetAttackPoints(Artefact artefact);

        void GetDefencePoints(Artefact artefact);
    }
}
