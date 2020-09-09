using System;

namespace csharp_basics_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFavoriteLanguage = "C#";
            Console.WriteLine("Let's Learn Some Basics!");
            Console.WriteLine("Let's Learn" + myFavoriteLanguage);

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + " " + lastName);

            Console.WriteLine("What do you wish your first name was?");
            firstName = Console.ReadLine();

            Console.WriteLine("Then your name would be " + firstName + " " + lastName);

            bool isWednesday = true;
            byte dayOfMonth = 9;
            int secondsInMonth = 2592000;

            Console.WriteLine("It's " + isWednesday + " that today is Wednesday.  Today's date is " + dayOfMonth + " and there are " + secondsInMonth + " seconds in this month");

            double percentMonthComplete;
            percentMonthComplete = 30 / dayOfMonth;

            Console.WriteLine("This month is " + percentMonthComplete + "% complete");

            char firstLetterOfMonth = 'S';

            Console.WriteLine("This month starts with the letter " + firstLetterOfMonth);
        }
    }
}
