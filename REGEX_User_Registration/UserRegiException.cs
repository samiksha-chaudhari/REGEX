using System;
using System.Collections.Generic;
using System.Text;

namespace REGEX_User_Registration
{
    public class UserRegiException : Exception
    {
        /// <summary>
        /// enum for exception type
        /// </summary>
        public enum ExceptionsType
        {
            Invalid_MESSAGE,
        }

        //creating type variable of type ExceptionType
        public ExceptionsType type;

        /// <summary>
        /// parametarize constructor
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="message"></param>
        public UserRegiException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
