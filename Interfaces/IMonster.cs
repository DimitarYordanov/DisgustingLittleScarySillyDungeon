using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProject.Positioning;
using GroupProject.Common.Enums;

namespace GroupProject.Interfaces
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
