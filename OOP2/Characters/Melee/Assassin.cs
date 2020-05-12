using System;
using OOP2.Characters.Enumerations;

namespace OOP2
{
    public class Assassin
    {
        private const string DEFAULT_NAME = "Assassin";
        private const Factions DEFAULT_FACTION = Factions.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string name;
        private Factions faction;

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
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
           
        }

        public Assassin(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        {
           
        }
        public Assassin(string name, int level, int abilityPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = DEFAULT_HEALTH_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = abilityPoints;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
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

        public static void GetAllDefaultInformation()
        {
            Console.WriteLine($"Defaut name: {DEFAULT_NAME}" +
                $"\nDefault faction: {DEFAULT_FACTION}" +
                $"\nDefaul level: {DEFAULT_LEVEL}" +
                $"\nDefault ability points: {DEFAULT_ABILITY_POINTS}" +
                $"\nDefault health points: {DEFAULT_HEALTH_POINTS}"
               
                );
        }
    }
}
