using System;
using System.Collections.Generic;
using System.Text;
using Day20_Regex_Test_Assignments.Custom_Exception;
using System.Text.RegularExpressions;

namespace Day20_Regex_Test_Assignments.UC4_Mobile_Number
{
    public class MobileNumber_Pattern
        {
            public static string Regex_MobileNumber = "^[0-9]{2}[ ][0-9]{10}$";

            public bool ValidatePhoneNumber(string phonenumber)
            {
                if (phonenumber == null)
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.INVALID_MESSAGE, "Invalid Email ID");
                }
                return Regex.IsMatch(phonenumber, Regex_MobileNumber);
            }
    }
}
