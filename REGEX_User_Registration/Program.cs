using System;

namespace REGEX_User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Patterns patterns = new Patterns();
            int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {
                Console.WriteLine("1.First Name  2.Last Name  3.Email ID  4.Exit");
                Console.WriteLine("Choose Option :");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        Console.WriteLine("Enter First Name: ");
                        string str = Console.ReadLine();
                        Console.WriteLine(patterns.validateFirstName(str));
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name: ");
                        string str1 = Console.ReadLine();
                        Console.WriteLine(patterns.validateLastName(str1));
                        break;
                    case 3:
                        Console.WriteLine("Enter Email ID: ");
                        string str2 = Console.ReadLine();
                        Console.WriteLine(patterns.validateEmailId(str2));
                        break;
                    default:
                        Console.WriteLine("End");//default condition
                        defcount++;
                        break;
               
                }
            }
        }
    }
}
