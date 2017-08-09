using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Heroes
{
    public abstract class Character
    {
        //fields
        private int health;
        private int strength;
        private int intelligence;
        private int agility;

        //constructor
        protected Character(int health, int strength, int intelligence, int agility)
        {
            this.Health = health;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Agility = agility;
        }

        //properties
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public int Strength
        {
            get
            {
                return this.strength;
            }
            private set
            {
                this.strength = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return this.intelligence;
            }
            private set
            {
                this.intelligence = value;
            }
        }

        public int Agility
        {
            get
            {
                return this.agility;
            }
            private set
            {
                this.agility = value;
            }
        }
        //methods

        protected virtual int GetAttackPoints()
        {
            var atackPoints = (this.Strength + this.Agility) / this.Intelligence;
            return atackPoints;
        }

        protected virtual int GetDefencePoints()
        {
            var defencePoints = this.Agility + (this.Strength / 2);
            return defencePoints;
        }

        protected virtual int GetAttackPointsFromWeapon()
        {
            var atackPoints = (this.Strength + this.Agility) / this.Intelligence;
            return atackPoints;
        }
        protected virtual int GetDefencePointsFrom()
        {
            var defencePoints = this.Agility + (this.Strength / 2);
            return defencePoints;
        }
    }
}
