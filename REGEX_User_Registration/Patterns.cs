using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_User_Registration
{
    public class Patterns
    {
        //pattern for firstname
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z A-Z]*$";
        /// <summary>
        /// method to check first name
        /// </summary>
        /// <param name="FirstName"></param>
        /// <returns></returns>
       /*
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);
        }
       */

        public bool validateFirstName(string FirstName)
        {
            if (FirstName == null)
            {
                throw new UserRegiException(UserRegiException.ExceptionsType.Invalid_MESSAGE, "Invalid FirstName");
            }
            return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);
        }

        //pattern for lastname
        public static string REGEX_LASTNAME = "^[A-Z][a-z A-Z]*$";
        /// <summary>
        /// method to check last name
        /// </summary>
        /// <param name="LastName"></param>
        /// <returns></returns>
       /*
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, REGEX_LASTNAME);
        }
       */
        public bool validateLastName(string LastName)
        {
            if (LastName == null)
            {
                throw new UserRegiException(UserRegiException.ExceptionsType.Invalid_MESSAGE, "Invalid LastName");
            }
            return Regex.IsMatch(LastName, REGEX_FIRSTNAME);
        }

        //pattern for email
        public static string REGEX_EMAILID = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        /// <summary>
        /// method to check email id
        /// </summary>
        /// <param name="EmailId"></param>
        /// <returns></returns>
        /*
        public bool validateEmailId(string EmailId)
        {
            return Regex.IsMatch(EmailId, REGEX_EMAILID);
        }
        */
        public bool validateEmailId(string EmailId)
        {
            if (EmailId == null)
            {
                throw new UserRegiException(UserRegiException.ExceptionsType.Invalid_MESSAGE, "Invalid EmailId");
            }
            return Regex.IsMatch(EmailId, REGEX_EMAILID);
        }


        //pattern for phone number
        public static string REGEX_PHONENUMBER = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}$";
        /// <summary>
        /// method to check phone number
        /// </summary>
        /// <param name="PhoneNumber"></param>
        /// <returns></returns>
       /*
        public bool validatePhoneNumber(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, REGEX_PHONENUMBER);
        }
       */
        public bool validatePhoneNumber(string PhoneNumber)
        {
            if (PhoneNumber == null)
            {
                throw new UserRegiException(UserRegiException.ExceptionsType.Invalid_MESSAGE, "Invalid PhoneNumber");
            }
            return Regex.IsMatch(PhoneNumber, REGEX_PHONENUMBER);
        }


        //pattern for password
        public static string REGEX_PASSWORD = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8,}$";
        /// <summary>
        /// method to check password
        /// </summary>
        /// <param name="PassWord"></param>
        /// <returns></returns>
        /*
        public bool validatePassWord(string PassWord)
        {
            return Regex.IsMatch(PassWord, REGEX_PASSWORD);
        }
        */
        public bool validatePassWord(string PassWord)
        {
            if (PassWord == null)
            {
                throw new UserRegiException(UserRegiException.ExceptionsType.Invalid_MESSAGE, "Invalid PassWord");
            }
            return Regex.IsMatch(PassWord, REGEX_PASSWORD);
        }
    }

}
