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

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }

        public string Name { get; set; }
        public string Faction { get; set; }

        public Chainlink BodyArmor { get; set; }
        public Axe Weapon { get; set; }

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
