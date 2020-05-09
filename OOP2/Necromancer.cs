using System;
namespace OOP2
{
    public class Necromancer
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string name;
        private string faction;

        private LeatherVest bodyArmor;
        private Sword weapon;

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }

        public string Name { get; set; }
        public string Faction { get; set; }

        public LeatherVest BodyArmor { get; set; }
        public Sword Weapon { get; set; }

    }
}
