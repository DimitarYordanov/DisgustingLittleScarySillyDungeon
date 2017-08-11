using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisgustingLittleSillyScaryDungeon.Common.Positioning;
using DisgustingLittleSillyScaryDungeon.Common.Enums;
using DisgustingLittleSillyScaryDungeon.Contracts.Monsters;
using DisgustingLittleSillyScaryDungeon.Contracts.PlayerCharacters;

namespace DisgustingLittleSillyScaryDungeon.Characters.Monsters
{
    public abstract class Monster : IMonster
    {
        private int health;
        private int attack;
        private int defense;
        private Points position;
        private string battlecry;

        public Monster(int health, int attack, int defense, string battlecry)
        {
            this.Health = health;
            this.Attack = attack;
            this.Defense = defense;
            this.Position = position;
            this.Battlecry = battlecry;
        }

        public abstract MonsterType Type { get; }

        public int Health {
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
            get
            {
                return this.attack;
            }
            protected   set
            {
                this.attack = value;
            }

        }

        public int Defense
        {
            get
            {
                return this.defense;
            }
            protected set
            {
                this.defense = value;
            }
        }

        public Points Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }

        

        public string Battlecry
        {
            get
            {
                return this.battlecry;
            }
            set
            {
                this.battlecry = value;
            }

        }
        

        public void AttackMove(IHero target)
        {
        //    int rnd = Guid.NewGuid().GetHashCode();
        //    int damageDone = rnd % this.MaxDamage - Character.Defence;
        //    if (damageDone > 0)
        //    {
        //        character.Health -= damageDone;
        //    }
        }
        
        public override string ToString()
        {
            return this.Battlecry;
        }
    }
}
