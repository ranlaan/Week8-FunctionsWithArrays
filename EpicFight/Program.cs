using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            string heroweapon, villainweapon;
            hero = RandomHero();
            heroweapon = RandomWeapon();
            villainweapon = RandomWeapon();
            villain = RandomVillain();
            Console.WriteLine($"{hero} will fight with {villain}");
            Console.WriteLine($"{hero} will fight with {heroweapon}");
            Console.WriteLine($"{villain} wil fight with {villainweapon}");

        }

        private static int RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string RandomHero()
        {
            string[] heroes = { "Batman", "Spongebob", "Spiderman", "Patrick", "Lara Croft" };
            
            return heroes[RandomIndex(heroes)];
        }

        private static string RandomVillain()
        {
            string[] villain = { "Darth Vader", "Squidward", "Venom", "Darth Maul", "Mr. Crabs" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villain.Length);

            string randomVillain = villain[randomIndex];
            return randomVillain;
        }

        private static string RandomWeapon()
        {
            string[] weapons = { "Spoon", "Frying pan", "Glock", "Tree", "Guitar" };

            return weapons[RandomIndex(weapons)];
        }

    }
}
