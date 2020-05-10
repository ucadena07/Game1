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
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    abilityPoints = value;
                }
                else
                {
                    Console.WriteLine("Please enter a number in the range of 0 to 10");
                }
            }
        }

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    healthPoints = value;
                }
                else
                {
                    Console.WriteLine("Please enter a number in the range of 0 to 100");
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    level = value;
                }
                else
                {
                    Console.WriteLine("Please enter a number in the range of 1 - 100");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    name = value;
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
                return faction;
            }
            set
            {
                if (value == "Melee" || value == "Spellcaster")
                {
                    faction = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate faction! should be \"Melee\" or \"Spellcaster\"");
                }
            }
        }

        public LeatherVest BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }
        public Sword Weapon
        {
            get
            { return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Assassin()
        {

        }

        public void Raze()
        {

        }

        public void Bleed()
        {

        }

        public  void Survival()
        {

        }
    }
}
