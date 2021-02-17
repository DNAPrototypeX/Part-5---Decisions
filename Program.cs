using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5___Decisions
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.
            Console.WriteLine("1.");
            int age = 0;
            Console.Write("What is your age ?: ");
            while (!Int32.TryParse(Console.ReadLine(), out age) || Convert.ToInt32(age) < 0)
                Console.WriteLine("Enter a valid integer");
            if (age > 18)
                Console.WriteLine("Adult");
            else if (age > 12)
                Console.WriteLine("Teen");
            else if (age <= 5)
                Console.WriteLine("Toddler");
            else if (age <= 10)
                Console.WriteLine("Child");
            else if (age <= 12)
                Console.WriteLine("Preteen");
            Console.WriteLine();


            //2.
            Console.WriteLine("2.");
            int hurricaneClass = 0;         
            Console.WriteLine("Please select a hurricane category:");
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.WriteLine("5.");
            Console.Write("Choice: ");
            while (!Int32.TryParse(Console.ReadLine(), out hurricaneClass) || hurricaneClass > 5 || hurricaneClass < 1)
                Console.WriteLine("Please choose one of the listed categories");
            if (hurricaneClass == 1)
                Console.WriteLine("This hurricane category has wind speeds of 75-95 mph, or 64-82 kt, or 119-153 kph");
            else if (hurricaneClass == 2)
                Console.WriteLine("This hurricane category has wind speeds of 96-110 mph, or 83-95 kt, or 154-177 kph");
            else if (hurricaneClass == 3)
                Console.WriteLine("This hurricane category has wind speeds of 111-130 mph, or 96-113 kt, or 178-209 kph");
            else if (hurricaneClass == 4)
                Console.WriteLine("This hurricane category has wind speeds of 131-155 mph, or 114-135 kt, or 210-249 kph");
            else
                Console.WriteLine("This hurricane category has wind speeds greater than 155 mph, or 135 kt, or 249 kph");
            Console.WriteLine();


            //3.
            Console.WriteLine("3.");
            Random randNumGenerator = new Random();
            int userInput = 0;
            int randNum = randNumGenerator.Next(2, 7);
            Console.WriteLine("Input an integer preferably greater than or equal to 6");
            while (!Int32.TryParse(Console.ReadLine(), out userInput) || userInput < randNum)
                Console.WriteLine("Please enter a valid integer, or try again (Your number may have been lower than the random number)");
            Console.WriteLine($"{userInput}/{randNum}");
            if (userInput % randNum == 0)
                Console.WriteLine("Divisible");
            else
                Console.WriteLine("Not divisible");


            Console.ReadLine();
        }
    }
}
