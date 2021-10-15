using System;

namespace RegexAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC 1
            Console.WriteLine("Use Case 1");
            Console.WriteLine("\n");
            Console.WriteLine("Enter The First Name: ");
            string userFirstName = Console.ReadLine();
            FirstName.validateFirstName(userFirstName);
        }
    }
}
