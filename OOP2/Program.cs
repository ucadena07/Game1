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
        bool gameOver = false;

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

        while (!gameOver)
        {
            //. 1 Take a random melee
            // .2 Take a randoom spellcaster

            spellTeam[0].TakeDamage(meleeTeam[0].Attack());

            // .3 Melee attacks spellcaster
            // 3.1 Check if the character died and remove him from the team.
            // 3.2 If dead, get another character from the team

            meleeTeam[0].TakeDamage(spellTeam[0].Attack());

            // .4 Spellcaster attacks Melee
            // 4.1 Check if the character died and remove him from the team.
            // 4.2 If dead, get another character from the team

            // .5 If no character are alive from either team gameOver = true;
        }

    }
}

