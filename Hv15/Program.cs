using Hv15.Models;

namespace Hv15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Apple
            {
                Price = 5,
                Sort = "Golden",
                VitaminA = 42,
                VitaminB = 43
            };

            Fruit fruit2 = new Pineapple
            {
                Price = 25,
                Sort = "Tropical",
                VitaminD = 50,
                VitaminE = 100
            };

            Fruit fruit3 = new Orange
            {
                Price = 30,
                Sort = "Citrus",
                VitaminC = 60,
            };

            Fruit[] basket = { fruit, fruit2, fruit3 };
            foreach (Fruit item in basket)
            {
                if (item is Apple apple)
                {
                    Console.WriteLine($"Apple: Price-{apple.Price}, Sort-{apple.Sort}, VitaminA-{apple.VitaminA}, VitaminB-{apple.VitaminB}");
                }
                else if (item is Pineapple pineapple)
                {
                    Console.WriteLine($"Pineapple: Price-{pineapple.Price}, Sort-{pineapple.Sort}, VitaminD-{pineapple.VitaminD},VitaminE-{pineapple.VitaminE}");
                }
                else if (item is Orange orange)
                {
                    Console.WriteLine($"Orange: Price-{orange.Price},Sort-{orange.Sort}, VitaminC-{orange.VitaminC}");
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
            }
            

        }
    }
}
