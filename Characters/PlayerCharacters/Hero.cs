using DisgustingLittleSillyScaryDungeon.Artefacts;
using DisgustingLittleSillyScaryDungeon.Contracts.PlayerCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisgustingLittleSillyScaryDungeon.Contracts;

namespace DisgustingLittleSillyScaryDungeon.Characters.PlayerCharacters
{
    public abstract class Hero : IHero
    {
        //fields
        private int health;
        private int attack;
        private int defense;
        private int strength;
        private int intelligence;
        private int agility;

        //constructor
        public Hero(int health, int strength, int intelligence, int agility)
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

        public int Attack
        {
            get { return this.attack; }
            protected set
            {
                this.attack = value;
            }
        }

        public int Defense
        {
            get { return this.defense; }
            protected set
            {
                this.defense = value;
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

        public abstract void GetAttackPoints(Artefact artefact);

        public abstract void GetDefencePoints(Artefact artefact);          
    }
}
