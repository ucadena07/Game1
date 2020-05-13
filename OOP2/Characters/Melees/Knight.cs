using System;
using OOP2.Characters.Enumerations;
using OOP2.Characters.Melees;

namespace OOP2
{
    public class Knight : Melee
    {
        private const string DEFAULT_NAME = "Knight";
        private const Factions DEFAULT_FACTION = Factions.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private readonly Hammer DEFAULT_WEAPON = new Hammer();
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();

   
        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }  

        public Knight(string name, int level)
            : this(name,level, DEFAULT_ABILITY_POINTS)
        {
            
        }

        public Knight(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
           
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int HolyBlow()
        {
            throw new NotImplementedException();
        }

        public int PurifySoul()
        {
            throw new NotImplementedException();
        }

        public int RighteousWings()
        {
            throw new NotImplementedException();
        }

        public override int Attack()
        {
            return this.HolyBlow();
        }

        public override int SpecialAttack()
        {
            return this.PurifySoul();
        }

        public override int Defend()
        {
            return this.RighteousWings();
        }
    }
}
