using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

                if (city == "Sofia")
            {
                if (item == "coffee")
                {
                    price = 0.50;
                }
                if (item == "water")
                {
                    price = 0.80;
                }
                if (item == "beer")
                {
                    price = 1.20;
                }
                if (item == "sweets")
                {
                    price = 1.45;
                }
                if (item == "peanuts")
                {
                    price = 1.60;
                }
            }

            if (city == "Plovdiv")
            {
                if (item == "coffee")
                {
                    price = 0.40;
                }
                if (item == "water")
                {
                    price = 0.70;
                }
                if (item == "beer")
                {
                    price = 1.15;
                }
                if (item == "sweets")
                {
                    price = 1.30;
                }
                if (item == "peanuts")
                {
                    price = 1.50;
                }
            }

            if (city == "Varna")
            {
                if (item == "coffee")
                {
                    price = 0.45;
                }
                if (item == "water")
                {
                    price = 0.70;
                }
                if (item == "beer")
                {
                    price = 1.10;
                }
                if (item == "sweets")
                {
                    price = 1.35;
                }
                if (item == "peanuts")
                {
                    price = 1.55;
                }
            }

            double total = quantity * price;
            Console.WriteLine(total);

        }
    }
}
