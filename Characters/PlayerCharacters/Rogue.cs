using DisgustingLittleSillyScaryDungeon.Artefacts;
using DisgustingLittleSillyScaryDungeon.Contracts.PlayerCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Characters.PlayerCharacters
{
    public class Rogue : Hero, IRougue
    {
        //fields
        private bool cloak;

        //constructor
        public Rogue(int health, int strength, int intelligence, int agility) 
            : base(health, strength, intelligence, agility)
        {
            this.Cloak = false;
            this.Attack = (2 * strength + agility) / intelligence;
            this.Defense = agility / 2 + (strength / 2);
        }

        public bool Cloak
        {
            get { return this.cloak; }
            set
            {
                this.cloak = value;
            }
        }

        public override void GetAttackPoints(Artefact artefact)
        {
            this.Attack += (2 * artefact.Strength + artefact.Agility) / artefact.Intelligence;

        }
        public override void GetDefencePoints(Artefact artefact)
        {
            this.Defense += artefact.Agility / 2 + (artefact.Strength / 2);
        }
    }
}
