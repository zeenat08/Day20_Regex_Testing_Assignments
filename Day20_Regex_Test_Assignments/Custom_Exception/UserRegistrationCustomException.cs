using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_Regex_Test_Assignments.Custom_Exception
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionsType
        {
            INVALID_MESSAGE
        }
        public ExceptionsType type;
        public UserRegistrationCustomException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;

        }

    }
}

    

