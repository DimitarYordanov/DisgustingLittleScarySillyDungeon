using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisgustingLittleSillyScaryDungeon.Positioning;
using DisgustingLittleSillyScaryDungeon.Common.Enums;

namespace DisgustingLittleSillyScaryDungeon.Interfaces
{
    public interface IMonster
    {
        Position Position { get; set; }
        int Health { get; set; }
        int MaxDamage { get; set; }
        int Defence { get; set; }
        string Battlecry { get; set; }

        void Attack();

    }
}
