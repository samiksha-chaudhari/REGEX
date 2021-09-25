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
    }
}
