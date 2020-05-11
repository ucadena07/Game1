using System;
namespace OOP2
{
    public class Assassin
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string name;
        private string faction;

        private LeatherVest bodyArmor;
        private Sword weapon;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    this.abilityPoints = 0;
                    Console.WriteLine("Please enter a number in the range of 0 to 10");
                }
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
                    this.level = 1;
                    Console.WriteLine("Please enter a number in the range of 1 - 100");
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
        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == "Melee" || value == "Spellcaster")
                {
                    this.faction = value;
                }
                else
                {
                    this.faction = "Melee";
                    Console.WriteLine("Inappropriate faction! should be \"Melee\" or \"Spellcaster\"");
                }
            }
        }

        public LeatherVest BodyArmor
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
        public Sword Weapon
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

        public Assassin()
        {

        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void Bleed()
        {
            throw new NotImplementedException();
        }

        public  void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
