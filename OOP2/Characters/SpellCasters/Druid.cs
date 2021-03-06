﻿using System;
using OOP2.Characters.Enumerations;
using OOP2.Characters.SpellCasters;

namespace OOP2
{
    public class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Druid";
        private const Factions DEFAULT_FACTION = Factions.Spellcaster;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();

      

        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }
        public Druid(string name, int level)
            : this(name, level, DEFAULT_MANA_POINTS)
        {
        
        }
        public Druid(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
          
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int MoonFire()
        {
            throw new NotImplementedException();
        }

        public int Starburst()
        {
            throw new NotImplementedException();
        }

        public int OneWithTheNature()
        {
            throw new NotImplementedException();
        }

        public override int Attack()
        {
            return this.MoonFire();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }

        public override int Defend()
        {
            return this.OneWithTheNature();
        }
    }
}
