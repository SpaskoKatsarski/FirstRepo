using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Read the input
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            // 2.Create a variable for the percentige of the commission
            double commission = 0;

            // 3. Create a series of conditions for the city
            // 3.1 In each condition for the city check the number of sales
            // 3.2 Change the variable commission according to the table
            if (city == "Sofia" || city == "Varna" || city == "Plovdiv")
            {
                if (city == "Sofia")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 7;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 8;
                    }
                    else if (sales > 10000)
                    {
                        commission = 12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
             
                }
                else if (city == "Varna")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 4.5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 7.5;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 10;
                    }
                    else if (sales > 10000)
                    {
                        commission = 13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (city == "Plovdiv")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 5.5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 8;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 12;
                    }
                    else if (sales > 10000)
                    {
                        commission = 14.5;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            else
            {
                Console.WriteLine("error");
            }
            
            double result = commission / 100 * sales;
            // 4. Print commision * sales

            if (result != 0)
            {
                Console.WriteLine($"{result:f2}");
            }
            
        }
    }
}
