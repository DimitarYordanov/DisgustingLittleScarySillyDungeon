using DisgustingLittleSillyScaryDungeon.Heroes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Heroes.Models
{
    public class Warrior : Character, IWarrior
    {
        //fields
        private int extraHealth;
        private int attack;
        private int defense;

        //constructor
        public Warrior(int health, int strength, int intelligence, int agility)
            : base(health, strength, intelligence, agility)
        {
            this.ExtraHealth = 100;
            this.Health = health + this.ExtraHealth;
            this.Attack = GetAttackPoints();
            this.Defense = GetDefencePoints();
        }

        //properties

        public int ExtraHealth
        {
            get { return this.extraHealth; } 
            set
            {
                this.extraHealth = value;
            }       
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

    }
}
