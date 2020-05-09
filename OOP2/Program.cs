using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior();
            Warrior badGuy = new Warrior();

            goodGuy.Name = "Bob";
            goodGuy.Damage = 10;
            goodGuy.HealthPoints = 100;


            badGuy.Name = "John";
            badGuy.Damage = 11;
            badGuy.HealthPoints = 70;

            //goodGuy.Greeting(badGuy.Name);
            goodGuy.Attack(badGuy);
            badGuy.Attack(goodGuy);

        }
    }
}
