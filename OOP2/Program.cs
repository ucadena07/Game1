using System;
using OOP2;

class Program
{
    static void Main(string[] args)
    {
        Assassin badguy = new Assassin();

        Tools.ColorfulWriteLine(badguy.BodyArmor.ToString(), ConsoleColor.Red);
    }
}

