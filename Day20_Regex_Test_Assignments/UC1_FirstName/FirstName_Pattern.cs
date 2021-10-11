using System;
using Day20_Regex_Test_Assignments.Custom_Exception;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Day20_Regex_Test_Assignments.UC1_FirstName

{
    public class FirstName_Pattern
    
    {
            public static string Regex_Firstname = "^[A-Z]{1}[a-z]{2,}$";
            public bool ValidateFirstName(string firstName)//method to check firstname
            {
                if (firstName == null)
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.INVALID_MESSAGE, "Invalid FirstName");
                }
                return Regex.IsMatch(firstName, Regex_Firstname);
            }
    }
}
