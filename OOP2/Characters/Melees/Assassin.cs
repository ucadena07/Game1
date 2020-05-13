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

            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int Raze()
        {
            throw new NotImplementedException();
        }

        public int Bleed()
        {
            throw new NotImplementedException();
        }

        public int Survival()
        {
            throw new NotImplementedException();
        }

        public override int Attack()
        {
            return this.Raze();
        }

        public override int SpecialAttack()
        {
           return this.Bleed();
        }

        public override int Defend()
        {
            return this.Survival();
        }
    }
}
