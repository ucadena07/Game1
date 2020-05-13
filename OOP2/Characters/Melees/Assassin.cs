using System;
using OOP2.Characters.Enumerations;
using OOP2.Characters.Melees;

namespace OOP2
{

    public class Assassin : Melee
    {
        private const string DEFAULT_NAME = "Assassin";
        private const Factions DEFAULT_FACTION = Factions.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();

        private LeatherVest bodyArmor;
        private Sword weapon;

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
            : base(name, level, abilityPoints)
        {
           
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;

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
