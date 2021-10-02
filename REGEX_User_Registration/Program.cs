using System;

namespace REGEX_User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Patterns patterns = new Patterns();//creating object
            int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {
                Console.WriteLine("1.First Name  2.Last Name  3.Email ID  4.Phone No.  5.Password  6.Exit");
                Console.WriteLine("Choose Option :");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        Console.WriteLine("Enter First Name: ");
                        string str = Console.ReadLine();
                        bool result= patterns.ValidateFirstName(str, Patterns.REGEX_FIRSTNAME);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name: ");
                        string str1 = Console.ReadLine();
                        bool result1 = patterns.ValidateLastName(str1, Patterns.REGEX_LASTNAME);
                        Console.WriteLine(result1);
                        break;
                    case 3:
                        Console.WriteLine("Enter how many email do you want to check:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)//checking email validate till n
                        {
                            Console.WriteLine("Enter Email ID: ");
                            string str2 = Console.ReadLine();
                            bool result3 = patterns.ValidateEmail(str2, Patterns.REGEX_EMAILID);
                            Console.WriteLine(result3);
                        }
                            break;
                    case 4:
                        Console.WriteLine("Enter Phone Number: ");
                        string str3 = Console.ReadLine();
                        bool result4 = patterns.ValidatePhoneNum(str3, Patterns.REGEX_PHONENUMBER);
                        Console.WriteLine(result4);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password: ");
                        string str4 = Console.ReadLine();
                        bool result5 = patterns.ValidatePassword(str4, Patterns.REGEX_PASSWORD);
                        Console.WriteLine(result5);
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
