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

            //Use Case 2
            Console.WriteLine("Use Case 2");
            Console.WriteLine("\n");
            Console.WriteLine("Enter The Last Name: ");
            string userLastName = Console.ReadLine();
            LastName.validateLastName(userLastName);

            //Use Case 3
            Console.WriteLine("Use Case 3");
            Console.WriteLine("\n");
            Console.WriteLine("Enter The Email Id: ");
            string userEmailId = Console.ReadLine();
            EmailId.validateEmailId(userEmailId);
        }
    }
}
