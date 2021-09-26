using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            bool isOpened = hours >= 10 && hours <= 18;

            if (isOpened)
            {
                if (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday" || dayOfTheWeek == "Saturday")
                {
                    Console.WriteLine("open");
                }
            }
            else if (!isOpened)
            {
                Console.WriteLine("closed");
            }
            if (dayOfTheWeek == "Sunday")          
            {
                Console.WriteLine("closed");
            }

        }
    }
}
