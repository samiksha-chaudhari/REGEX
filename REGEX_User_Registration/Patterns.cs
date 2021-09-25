using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_User_Registration
{
    class Patterns
    {
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z A-Z]*$";
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);
        }

        public static string REGEX_LASTNAME = "^[A-Z][a-z A-Z]*$";
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, REGEX_LASTNAME);
        }

        public static string REGEX_EMAILID = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public bool validateEmailId(string EmailId)
        {
            return Regex.IsMatch(EmailId, REGEX_EMAILID);
        }

        public static string REGEX_PHONENUMBER = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}$";
        public bool validatePhoneNumber(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, REGEX_PHONENUMBER);
        }
    }

}
