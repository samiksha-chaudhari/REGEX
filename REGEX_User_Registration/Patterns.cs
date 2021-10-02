using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_User_Registration
{
    public class Patterns
    {
        //REGEX patterns
        public const string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{3,}$";
        public const string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{3,}$";
        public const string REGEX_PHONENUMBER = "^[9]{1}[1]{1}[ ]{1}[0-9]{10}$";
        public const string REGEX_EMAILID = "^[a-z0-9A-Z]+([.][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";
        public const string REGEX_PASSWORD = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";

        //Func<string, string, bool> Test = (x, y) => x > y; Using LAMBDA EXP
        public Func<string, string, bool> ValidateFirstName = (name, FIRSTNAME_REGEX) => Regex.IsMatch(name, FIRSTNAME_REGEX);
        public Func<string, string, bool> ValidateLastName = (lastname, LASTNAME_REGEX) => Regex.IsMatch(lastname, LASTNAME_REGEX);
        public Func<string, string, bool> ValidatePhoneNum = (phonenum, PHONENUM_REGEX) => Regex.IsMatch(phonenum, PHONENUM_REGEX);
        public Func<string, string, bool> ValidateEmail = (email, EMAIL_REGEX) => Regex.IsMatch(email, EMAIL_REGEX);
        public Func<string, string, bool> ValidatePassword = (password, PASSWORD_REGEX) => Regex.IsMatch(password, PASSWORD_REGEX);


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
        /*
         public bool validateFirstName(string FirstName)
         {
             if (FirstName == null)
             {
                 throw new UserRegiException(UserRegiException.ExceptionsType.Invalid_MESSAGE, "Invalid FirstName");
             }
             return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);
         }
        */
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
        /*
         public bool validateLastName(string LastName)
         {
             if (LastName == null)
             {
                 throw new UserRegiException(UserRegiException.ExceptionsType.Invalid_MESSAGE, "Invalid LastName");
             }
             return Regex.IsMatch(LastName, REGEX_FIRSTNAME);
         }
         */
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
        /*
        public bool validateEmailId(string EmailId)
        {
            if (EmailId == null)
            {
                throw new UserRegiException(UserRegiException.ExceptionsType.Invalid_MESSAGE, "Invalid EmailId");
            }
            return Regex.IsMatch(EmailId, REGEX_EMAILID);
        }
        */
        
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

        /*
        public bool validatePhoneNumber(string PhoneNumber)
        {
            if (PhoneNumber == null)
            {
                throw new UserRegiException(UserRegiException.ExceptionsType.Invalid_MESSAGE, "Invalid PhoneNumber");
            }
            return Regex.IsMatch(PhoneNumber, REGEX_PHONENUMBER);
        }

        */
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
        /*
        public bool validatePassWord(string PassWord)
        {
            if (PassWord == null)
            {
                throw new UserRegiException(UserRegiException.ExceptionsType.Invalid_MESSAGE, "Invalid PassWord");
            }
            return Regex.IsMatch(PassWord, REGEX_PASSWORD);
        }
          */

    }
}
