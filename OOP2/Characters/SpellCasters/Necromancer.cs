﻿using System;
using OOP2.Characters.Enumerations;
using OOP2.Characters.SpellCasters;

namespace OOP2
{
    public class Necromancer : Spellcaster
    {
        private const string DEFAULT_NAME = "Necromancer";
        private const Factions DEFAULT_FACTION = Factions.Spellcaster;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();

        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
           
        }

        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_MANA_POINTS)
        {
            
        }
        public Necromancer(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
           
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
           
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.ShadowRage();
        }

        public override void SpecialAttack()
        {
            this.VampireTouch();
        }

        public override void Defend()
        {
            this.BoneShield();
        }
    }
}
