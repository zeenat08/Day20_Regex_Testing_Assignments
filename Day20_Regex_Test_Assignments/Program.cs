using System;
using Day20_Regex_Test_Assignments.UC1_FirstName;
using Day20_Regex_Test_Assignments.UC2_LastName;
using Day20_Regex_Test_Assignments.UC3_9_Email;
using Day20_Regex_Test_Assignments.UC4_Mobile_Number;
using Day20_Regex_Test_Assignments.UC5_6_7_8_Password;
using Day20_Regex_Test_Assignments.Custom_Exception;


namespace Day20_Regex_Test_Assignments
{
    class Program
    {
            public static void Main(string[] args)
        {
            Console.WriteLine("******WELCOME TO REGEX USER REGISTRATION PROBLEM WITH EXCEPTION HANDLING******\n");

            //*****************FIRST NAME********************
            FirstName_Pattern pattern1 = new FirstName_Pattern();
            Console.Write("Enter FirstName: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("FirstName:" + pattern1.ValidateFirstName(firstName));

            //*****************LAST NAME**********************
            LastName_Pattern pattern2 = new LastName_Pattern();
            Console.Write("Enter LastName: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("LastName: " + pattern2.ValidateLastName(lastname));

            //*****************EMAIL ID***********************
            Email_Pattern pattern3 = new Email_Pattern();
            Console.Write("Enter Email ID: ");
            string email = Console.ReadLine();
            Console.WriteLine(pattern3.ValidateEmail(email));

            //******************MOBILE NUMBER*********************
            MobileNumber_Pattern pattern4 = new MobileNumber_Pattern();
            Console.Write("Enter MobileNumber: ");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(pattern4.ValidatePhoneNumber(mobileNumber));

            //*******************PASSWORD*************************
            Password_Pattern pattern5 = new Password_Pattern();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();
                Console.WriteLine(pattern5.ValidatePassword(password));

            }
    }
}

   