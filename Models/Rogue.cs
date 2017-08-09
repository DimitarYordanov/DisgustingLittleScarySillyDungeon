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
    }
}
