using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Heroes.Contracts
{
    public interface IRougue : IHero
    {
        bool Cloak { get; set; }
    }
}
