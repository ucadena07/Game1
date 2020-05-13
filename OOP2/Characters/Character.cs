using System;
using OOP2.Armors;
using OOP2.Characters.Enumerations;
using OOP2.Characters.Interfaces;
using OOP2.Weapons;

namespace OOP2.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private string name;
        private Factions faction;

        private bool isAlive;

        private int healthPoints;
        private int level;
        private int score;

        private Armor bodyArmor;
        private Weapon weapon;

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            private set
            {
                this.isAlive = value;
            }
        }

        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }


        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.healthPoints = value;
                }
                else
                {
                    this.healthPoints = 0;
                    Console.WriteLine("Please enter a number in the range of 0 to 100");
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    level = 1;
                    throw new ArgumentOutOfRangeException(string.Empty, "Please enter a number in the range of 1 - 100");

                }
            }
        }
        public int Score
        {
            get
            {
                return this.score;
            }
            private set
            {
                this.score = value;
            }
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Name must be 2 to 10 characters long.");
                }
            }
        }
        public Factions Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;

            }
        }

        public Character()
        {

        }

        public Character(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public abstract int Attack();


        public abstract int SpecialAttack();


        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("hahahah WEAK");
            }
            if (!this.isAlive)
            {
                Console.WriteLine($"{this.name} received {damage} from {attackerName}  damage, and is now dead" );
            }
            else
            {
                Console.WriteLine($"{this.name} received {damage} from {attackerName}, and is now has {this.healthPoints}");
            }
        }
        
    }
}
