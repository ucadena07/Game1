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

        Random rng = new Random();

        int currentMelee = 0;
        int currentSpellcaster = 0;
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
            currentMelee = rng.Next(0, meleeTeam.Count);
            currentSpellcaster = rng.Next(0, spellTeam.Count);
         

            spellTeam[currentSpellcaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name);

            if (!spellTeam[currentSpellcaster].IsAlive)
            {
                meleeTeam[currentMelee].WonBatle();
                spellTeam.Remove(spellTeam[currentSpellcaster]);

                if (spellTeam.Count == 0)
                {
                    Console.WriteLine("Melee teams win");
                    break;
                }
                else
                {
                    currentSpellcaster = rng.Next(0, spellTeam.Count);
                }
            }
          
           

            meleeTeam[currentMelee].TakeDamage(spellTeam[currentSpellcaster].Attack(), spellTeam[currentSpellcaster].Name);

            if (!meleeTeam[currentMelee].IsAlive)
            {
                spellTeam[currentSpellcaster].WonBatle();
                meleeTeam.Remove(meleeTeam[currentMelee]);

                if (meleeTeam.Count == 0)
                {
                    Console.WriteLine("Spellcaster teams win");
                    break;
                }
                else
                {
                    currentMelee = rng.Next(0, meleeTeam.Count);
                }


            }

            // .4 Spellcaster attacks Melee
            // 4.1 Check if the character died and remove him from the team.
            // 4.2 If dead, get another character from the team

            // .5 If no character are alive from either team gameOver = true;
        }

    }
}

