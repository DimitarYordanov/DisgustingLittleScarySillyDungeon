using DisgustingLittleSillyScaryDungeon.Artefacts;
using DisgustingLittleSillyScaryDungeon.Heroes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Heroes.Models
{
    public class Mage : Character, IMage
    {
        //fields
        private int fireball;
        private int attack;
        private int defense;

        //constructor
        public Mage(int health, int strength, int intelligence, int agility)
            : base(health, strength, intelligence, agility)
        {
            this.Fireball = 5;
            this.Attack = (strength / 3 + agility) / intelligence + this.fireball;
            this.Defense = 2 * agility + strength / 2;          
        }

        

        //properties
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

        public int Fireball
        {
            get { return this.fireball; }
            set
            {
                this.fireball = value;
            }
        }

        public override void GetAttackPoints(Artefact artefact)
        {
            this.attack += (artefact.Strentgh / 3 + artefact.Agility) / artefact.Intelligence;

        }
        public override void GetDefencePoints(Artefact artefact)
        {
            this.defense += 2 * artefact.Agility + (artefact.Strentgh / 2);
        }
    }
}
