using System;
using System.Collections.Generic;
using OOP2;
using OOP2.Characters;
using OOP2.Characters.Melees;
using OOP2.Characters.SpellCasters;

class Program
{
    static void Main(string[] args)
    {
        List<Character> characters = new List<Character>()
        {
            new Warrior(),
            new Warrior(),
            new Warrior(),
            //new Knight(),
            //new Assassin(),
            new Mage(),
            new Mage(),
            new Mage()
            //new Druid(),
            //new Necromancer()
        };

        List<Melee> meleeTeam = new List<Melee>();
        List<Spellcaster> spellTeam = new List<Spellcaster>();

        foreach (var character in characters)
        {
            if (character is Melee)
            {
                meleeTeam.Add((Melee)character);
            }
            else if (character is Spellcaster)
            {
                spellTeam.Add((Spellcaster)character);
            }
        }

       
    }
}

