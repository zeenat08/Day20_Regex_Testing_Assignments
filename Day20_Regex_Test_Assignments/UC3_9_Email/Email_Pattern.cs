using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Day20_Regex_Test_Assignments.Custom_Exception;

namespace Day20_Regex_Test_Assignments.UC3_9_Email
{
    public class Email_Pattern
    {
        //^[a-zA-Z0-9]+ --> Starts with Letters and Numbers(At least one char is required)
        //([.#_$+-][a-zA-Z0-9]+)* -->for 1st optional part
        //[@] --> Followed by @
        //[a-zA-Z0-9]+ --> should have Alphabets and Numbers(At least one char is required)
        //[.] --> followed by .
        //[a-zA-Z]{2-3] --> only aphabets and no numbers and max 3
        //([.][a-zA-z0-9]{2})? --> for 2nd optional part

        public static string Regex_Email = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        public bool ValidateEmail(string email)
        {
            if (email == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.INVALID_MESSAGE, "Invalid Email");
            }
            return Regex.IsMatch(email, Regex_Email);
        }
    }
}
