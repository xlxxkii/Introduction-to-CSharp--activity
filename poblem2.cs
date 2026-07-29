using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        string fullName = firstName + " " + lastName;

        Console.WriteLine("Full Name: " + fullName);
    }
}
