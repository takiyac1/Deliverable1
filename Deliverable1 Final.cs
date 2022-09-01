using System;

class Program
{
    public static void Main(string[] args)
    {


        while (true)
        {

            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            string input =

            Console.ReadLine();
            int num1 = int.Parse(input);

            int num2 = num1 * 2;
            int num3 = num1 * 2;
            int num4 = num1 * 4;





            Console.WriteLine();

            Console.WriteLine("You Need:");
            Console.WriteLine();
            //figure out how to indent//
            Console.WriteLine(num2 + " slices of bread");

            Console.WriteLine(num3 + " tablespoons of peanut butter");

            Console.WriteLine(num4 + " teaspoons of jelly");
            Console.WriteLine();

            Console.WriteLine("which is...");
            Console.WriteLine();

            int num5 = num2 / 28;

            double result = Math.Ceiling(0.02);

            Console.WriteLine(num5 + result + " loaves of bread");


            int num6 = num3 / 32;
            Console.WriteLine(num6 + result + " jars of peanut butter");

            int num7 = num4 / 48;
            Console.WriteLine(num7 + result + " jars of jelly");

            Console.WriteLine();



            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
            string answer;
            answer = Console.ReadLine();
            if (answer == "y" || answer == "Y" || answer == "yes" || answer == "YES")
            {
                continue;

            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Goodbye");
    }
}


