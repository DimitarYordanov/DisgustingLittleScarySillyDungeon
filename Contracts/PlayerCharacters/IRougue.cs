using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Contracts.PlayerCharacters
{
    public interface IRougue : IHero
    {
        bool Cloak { get; set; }
    }
}
