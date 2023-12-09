using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Access Control System");

        Console.Write("Please enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age >= 18)
            {
                Console.WriteLine("Access granted");
            }
            else if (age >= 15)
            {
                Console.Write("Do you have parental consent? (yes/no): ");
                string consent = Console.ReadLine().ToLower();

                if (consent == "yes")
                {
                    Console.WriteLine("Access granted");
                }
                else
                {
                    Console.WriteLine("Access denied");
                }
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
