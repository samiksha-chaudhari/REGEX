using System;

namespace REGEX_User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Patterns patterns = new Patterns();
            Console.WriteLine("Enter First Name: ");
            string str = Console.ReadLine();
            Console.WriteLine(patterns.validateFirstName(str));
        }
    }
}
