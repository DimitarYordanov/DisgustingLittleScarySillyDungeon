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
        public Mage(int health, int strength, int intelligence, int agility, int fireball) : base(health, strength, intelligence, agility)
        {
            this.Fireball = fireball;
            this.Attack = GetAttackPoints() + this.Fireball;
            this.Defense = GetDefencePoints();
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

    }
}
