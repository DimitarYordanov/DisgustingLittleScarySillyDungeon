using DisgustingLittleSillyScaryDungeon.Artefacts;
using DisgustingLittleSillyScaryDungeon.Contracts.PlayerCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Characters.PlayerCharacters
{
    public class Warrior : Hero, IWarrior
    {
        //fields
        private int extraHealth;
        

        //constructor
        public Warrior(int health, int strength, int intelligence, int agility)
            : base(health, strength, intelligence, agility)
        {
            this.ExtraHealth = 10;
            this.Health = health + this.ExtraHealth;
            this.Attack = (strength + agility) / intelligence;
            this.Defense = agility + (strength / 2);
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
        
        public override void GetAttackPoints(Artefact artefact)
        {
            this.Attack += (artefact.Strength + artefact.Agility) / artefact.Intelligence;
            
        }
        public override void GetDefencePoints(Artefact artefact)
        {
           this.Defense += artefact.Agility + (artefact.Strength / 2);
        }
    }
}
