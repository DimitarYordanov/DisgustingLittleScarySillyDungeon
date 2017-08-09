using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Heroes.Contracts
{
    public interface IWarrior : IHero
    {
        int ExtraHealth { get; set; }
    }
}
