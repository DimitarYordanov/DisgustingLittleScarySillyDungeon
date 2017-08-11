using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Contracts
{
    public interface ICharacter
    {
        int Health { get; }
        int Attack { get; }
        int Defense { get; }
    }
}
