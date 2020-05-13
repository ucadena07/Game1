using System;
using OOP2.Characters.Enumerations;
using OOP2.Characters.Melees;

namespace OOP2
{
    public class Warrior : Melee
    {
        private const string DEFAULT_NAME = "Warrior";
        private const Factions DEFAULT_FACTION = Factions.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private readonly Axe DEFAULT_WEAPON = new Axe();
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();

        private Chainlink bodyArmor;
        private Axe weapon;

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
            : base(name, level, abilityPoints)
        {
            
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
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
