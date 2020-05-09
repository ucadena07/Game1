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
