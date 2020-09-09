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

            Console.WriteLine("It's " + isWednesday + " that today is Wednesday. " +
                "Today's date is " + dayOfMonth + " and there are " + secondsInMonth + " seconds in this month.");
            Console.WriteLine("In 5 days the day will be " + (dayOfMonth + 5) + ".");
            Console.WriteLine("If you divide today's date by 2 the remainder is " + (dayOfMonth % 2) + ".");
            Console.WriteLine("It is " + (dayOfMonth > 10) + " that today's date is greater than 10.");

            double percentMonthComplete;
            percentMonthComplete = ((double)dayOfMonth / 31) * 100;
            Console.WriteLine("This month is " + percentMonthComplete + "% complete.");

            char firstLetterOfMonth = 'S';
            Console.WriteLine("This month starts with the letter " + firstLetterOfMonth + ".");

        }
    }
}
