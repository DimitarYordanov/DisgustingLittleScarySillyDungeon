using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisgustingLittleSillyScaryDungeon.Interfaces;
using DisgustingLittleSillyScaryDungeon.Positioning;
using DisgustingLittleSillyScaryDungeon.Common.Enums;

namespace DisgustingLittleSillyScaryDungeon.Characters.Monsters
{
    public abstract class Monster : IMonster
    {
        private int health;
        private int maxDamage;
        private Position position;
        private int defence;
        private string battlecry;

        public Monster(int health, int maxDamage, Position position, int defence, string battlecry)
        {
            this.Health = health;
            this.MaxDamage = maxDamage;
            this.Defence = defence;
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
        public int MaxDamage
        {
            get
            {
                return this.maxDamage;
            }
                 set
            {
                this.maxDamage = value;
            }

        }
        public Position Position
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
        public int Defence
        {
            get
            {
                return this.defence;
            }
            set
            {
                this.defence = value;
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
        

        public void Attack()
        {
            int rnd = Guid.NewGuid().GetHashCode();
            //return Math.Abs(rnd % this.MaxDamage);
        }

        //public void Attack(Character character)
        //{
        //    int rnd = Guid.NewGuid().GetHashCode();
        //    int damageDone = rnd % this.MaxDamage - Character.Defence;
        //    if (damageDone > 0)
        //    {
        //        character.Health -= damageDone;
        //    }
        //}

        public override string ToString()
        {
            return string.Format("{0}\nHealth: {1}\nDamage: {2}\nDefence: {3}\nPlace: {4}\nBattlecry: {5}",
               this.Type, this.Health, this.MaxDamage, this.Defence, this.Position, this.Battlecry);
        }
    }
}
