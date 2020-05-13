using System;
using System.Collections.Generic;
using OOP2;
using OOP2.Characters;

class Program
{
    static void Main(string[] args)
    {
        Character warrior = new Warrior();
        Character knight = new Knight();
        Character assassin = new Assassin();
        Character mage = new Mage();
        Character necromancer = new Necromancer();
        Character druid = new Druid();

        List<Character> meleeTeam = new List<Character>();
        List<Character> spellTeam = new List<Character>();

        meleeTeam.Add(warrior);
        meleeTeam.Add(knight);
        meleeTeam.Add(assassin);

        spellTeam.Add(mage);
        spellTeam.Add(necromancer);
        spellTeam.Add(druid);

        warrior.Attack();
    }
}

