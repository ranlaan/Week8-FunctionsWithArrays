using System;

namespace FunctionsWithReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "chicken wings", "boorgir", "french fries", "pizza", "chicken nuggets" };
            string[] drinks = { "coca-cola", "fanta", "sprite", "still water" };
            string[] movie = { "Avatar", "Black Panter", "Titanic" };

            //Displayrandom(foods);
            //Displayrandom(drinks);
            string randomSnack = PickRAndomFromArray(foods);
            string randomDrink = PickRAndomFromArray(drinks);
            string randomMovie = PickRAndomFromArray(movie);

            Console.WriteLine($"Computer picked {randomSnack} and {randomDrink} for a {randomMovie} movie night.");

        }



        private static string PickRAndomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomindex = rnd.Next(0, someArray.Length);
            string RandomElement = someArray[randomindex];

            return RandomElement;
        }

        private static void Displayrandom(string[] someArray)
        {
            Random rnd = new Random();
            int randomindex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"Computer has chosen {someArray[randomindex]}");
        }



    }
}
