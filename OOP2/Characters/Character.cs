using System;
using OOP2.Characters.Enumerations;
using OOP2.Characters.Interfaces;

namespace OOP2.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private string name;
        private Factions faction;

        private int healthPoints;
        private int level;

       

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

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
