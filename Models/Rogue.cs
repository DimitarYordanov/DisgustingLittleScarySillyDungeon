using DisgustingLittleSillyScaryDungeon.Artefacts;
using DisgustingLittleSillyScaryDungeon.Heroes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Heroes.Models
{
    public class Rogue : Character, IRougue
    {
        //fields
        private bool cloak;
        private int attack;
        private int defense;

        //constructor
        public Rogue(int health, int strength, int intelligence, int agility) 
            : base(health, strength, intelligence, agility)
        {
            this.Cloak = false;
            this.Attack = (2 * strength + agility) / intelligence;
            this.Defense = agility / 2 + (strength / 2);
        }

        public int Attack
        {
            get { return this.attack; }
            private set
            {
                this.attack = value;
            }
        }

        public int Defense
        {
            get { return this.defense; }
            private set
            {
                this.defense = value;
            }
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
            this.attack += (2 * artefact.Strentgh + artefact.Agility) / artefact.Intelligence;

        }
        public override void GetDefencePoints(Artefact artefact)
        {
            this.defense += artefact.Agility / 2 + (artefact.Strentgh / 2);
        }
    }
}
