using System;
using OOP2;

class Program
{
    static void Main(string[] args)
    {
        Warrior goodGuy = new Warrior(10, 100, "Bob");
        Warrior badGuy = new Warrior(11, 70, "John");

        goodGuy.Damage = 20;
        Console.WriteLine(goodGuy.Damage);
            

        //goodGuy.Greeting(badGuy.Name);
        goodGuy.Attack(badGuy);
        badGuy.Attack(goodGuy);

    }
}

