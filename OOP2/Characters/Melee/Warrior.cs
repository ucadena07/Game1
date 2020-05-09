using System;
namespace OOP2
{
    public class Warrior
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private int damage;

        private string name;
        private string faction;

        private Chainlink bodyArmor;
        private Axe weapon;

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                abilityPoints = value;
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
                healthPoints = value;
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
                level = value;
            }
        }

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
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
                name = value;
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
                faction = value;
            }
        }

        public Chainlink BodyArmor
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
        public Axe Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Warrior(int damage, int healthPoints, string name)
        {
            Damage = damage;
            HealthPoints = healthPoints;
            Name = name;
        }

        public void Greeting(string name)
        {
            Console.WriteLine($"{Name} greets {name}");
        }

        public void Attack(Warrior enemy)
        {
            enemy.HealthPoints -= Damage;
            Console.WriteLine($"{Name} is attacking {enemy.Name}. {enemy.Name} now has {enemy.HealthPoints} remaining ");
        }

        public void Strike()
        {

        }

        public void Execute()
        {

        }

        public void SkinHarden()
        {

        }
    }
}
