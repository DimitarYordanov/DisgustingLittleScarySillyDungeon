using DisgustingLittleSillyScaryDungeon.Artefacts;
using DisgustingLittleSillyScaryDungeon.Contracts.PlayerCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgustingLittleSillyScaryDungeon.Characters.PlayerCharacters
{
    public class Mage : Hero, IMage
    {
        //fields
        private int fireball;

        //constructor
        public Mage(int health, int strength, int intelligence, int agility)
            : base(health, strength, intelligence, agility)
        {
            this.Fireball = 5;
            this.Attack = (strength / 3 + agility) / intelligence + this.fireball;
            this.Defense = 2 * agility + strength / 2;          
        }

        

        //properties

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
            this.Attack += (artefact.Strength / 3 + artefact.Agility) / artefact.Intelligence;

        }
        public override void GetDefencePoints(Artefact artefact)
        {
            this.Defense += 2 * artefact.Agility + (artefact.Strength / 2);
        }
    }
}
