using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Day20_Regex_Test_Assignments.Custom_Exception;

namespace Day20_Regex_Test_Assignments.UC5_6_7_8_Password
{
    public class Password_Pattern
        {
            //public static string Regex_PSWD = "^([$#.%+@-~!]{1}([a-zA-Z0-9]*[A-Z]{1,}[0-9]{1,})){8,}$";
            public static string Regex_PSWD = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8,}$";
            public bool ValidatePassword(string password)
            {
                if (password == null)
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.INVALID_MESSAGE, "Invalid Password");
                }
                return Regex.IsMatch(password, Regex_PSWD);
            }
    }
}

