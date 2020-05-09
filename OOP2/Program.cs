using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior(10, 100, "Bob");
            Warrior badGuy = new Warrior(11, 70, "John");

            

            //goodGuy.Greeting(badGuy.Name);
            goodGuy.Attack(badGuy);
            badGuy.Attack(goodGuy);

        }
    }
}
