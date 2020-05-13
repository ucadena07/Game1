using System;
using OOP2.Characters;
using OOP2.Characters.Enumerations;
using OOP2.Characters.Interfaces;
using OOP2.Characters.Melees;

namespace OOP2
{
    public class Warrior : Melee, IAttack, IDefend
    {
        private const string DEFAULT_NAME = "Warrior";
        private const Factions DEFAULT_FACTION = Factions.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private readonly Axe DEFAULT_WEAPON = new Axe();
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();



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
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int Strike()
        {
            return base.Weapon.Damage + 10;
        }

        public int Execute()
        {
            return this.Execute();
        }

        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
} 
