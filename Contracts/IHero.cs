using DisgustingLittleSillyScaryDungeon.Artefacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Heroes.Contracts
{
    public interface IHero
    {
        int Attack { get; }

        int Defense { get; }

        int Health { get; set; }

        void GetAttackPoints(Artefact artefact);

        void GetDefencePoints(Artefact artefact);
    }
}
