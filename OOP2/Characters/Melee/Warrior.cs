using System;
namespace OOP2
{
    public class Warrior
    {
        private const string DEFAULT_NAME = "Warrior";
        private const string DEFAULT_FACTION = "Melee";

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private readonly Axe DEFAULT_WEAPON = new Axe();
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();


        private int abilityPoints;
        private int healthPoints;
        private int level;
        

        private string name;
        private string faction;

        private Chainlink bodyArmor;
        private Axe weapon;

        public int Id
        {
            get
            {
                return this.id;
            }
           
        }


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
                if(value.Length >= 2 && value.Length <= 10)
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

        public Chainlink BodyArmor
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
        public Axe Weapon
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

        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        {
            
        }

        public Warrior(string name, int level, int abilityPoints)
        {
   
            this.Name = name;
            this.Level = level;
            this.HealthPoints = DEFAULT_HEALTH_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = abilityPoints;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
} 
