using System;
using System.Collections.Generic;
using System.Text;

namespace REGEX_User_Registration
{
    public class UserRegiException : Exception
    {
        public enum ExceptionsType
        {
            Invalid_MESSAGE,
        }
        public ExceptionsType type;
        public UserRegiException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;

        }
    }
}
