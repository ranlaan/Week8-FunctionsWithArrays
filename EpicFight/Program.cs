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
            int heroHP = GenerateHP(hero);
            int villainHP = GenerateHP(villain);

            Console.WriteLine($"{hero} ({heroHP}hp) will fight with {villain} ({villainHP}hp)");
            Console.WriteLine($"{hero} will fight with {heroweapon}");
            Console.WriteLine($"{villain} will fight with {villainweapon}");

            while (heroHP > 0 && villainHP > 0)
            {
                heroHP = heroHP - Hit(villain, hero, villainweapon);
                villainHP = villainHP - Hit(hero, villain, heroweapon);
            }

            if(heroHP <= 0)
            {
                Console.WriteLine("Villain wins!");
            }
            else
            {
                Console.WriteLine($"{hero} has won!");
            }

        }

        private static int Hit(string characterOne, string characterTwo, string weapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, weapon.Length / 2);
            Console.WriteLine($"{characterOne} dealt {strike} damage!.");

            if (strike == weapon.Length /2 - 1)
            {
                Console.WriteLine($"Awesome! {characterOne} made a CRITICAL hit!");
            }
            else if (strike == 0)
            {
                Console.WriteLine($"{characterTwo} dodged the attack!");
            }

            return strike;
        }

        private static int GenerateHP(string someCharacter)
        {
            Random rnd = new Random();
            return rnd.Next(someCharacter.Length, someCharacter.Length + 10);
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
            string[] weapons = { "Spoon", "Frying pan", "Flip-flop", "Tree", "Guitar" };

            return weapons[RandomIndex(weapons)];
        }

    }
}
