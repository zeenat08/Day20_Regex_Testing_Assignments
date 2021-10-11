using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20_Regex_Test_Assignments;
using Day20_Regex_Test_Assignments.UC1_FirstName;
using Day20_Regex_Test_Assignments.UC2_LastName;
using Day20_Regex_Test_Assignments.UC3_9_Email;
using Day20_Regex_Test_Assignments.UC4_Mobile_Number;
using Day20_Regex_Test_Assignments.UC5_6_7_8_Password;
using Day20_Regex_Test_Assignments.Custom_Exception;

namespace Regex_Testing
{
    [TestClass]
    public class UnitTest1
    {
        //UC1
        [TestMethod]
        [ExpectedException(typeof(UserRegistrationCustomException))]
        public void Given_ValidateFirstName_If_Null_ShouldThrow_UserRegistrationCustomException()
        {
            //Arrange
            FirstName_Pattern patternMatch = new FirstName_Pattern();
            //bool expected = true;
            string expected = "Invalid FirstName";

            //Act
            var result = patternMatch.ValidateFirstName(null);
            //var result = patternMatch.ValidateFirstName("Siba");

            //Assert
            Assert.AreEqual(expected, result);
        }

        //UC2
        [TestMethod]
        [ExpectedException(typeof(UserRegistrationCustomException))]
        public void Given_ValidateLastName_If_Null_ShouldThrow_UserRegistrationCustomException()
        {
            //Arrange
            LastName_Pattern patternMatch = new LastName_Pattern();
            string expected = "Invalid LastName";

            //Act
            var result = patternMatch.ValidateLastName(null);
            //var result = patternMatch.ValidateLastName("Patro");

            //Assert
            Assert.AreEqual(expected, result);
        }

        //UC3_9
        [TestMethod]
        [ExpectedException(typeof(UserRegistrationCustomException))]
        public void Given_ValidateEmail_If_Null_ShouldThrow_UserRegistrationCustomException()
        {
            //Arrange
            Email_Pattern patternMatch = new Email_Pattern();
            bool expected = true;

            //Act
            var result = patternMatch.ValidateEmail(null);
            //var result = patternMatch.ValidateEmail("abc.xyz@bl.co.in");

            //Assert
            Assert.AreEqual(expected, result);
        }

        //UC4
        [TestMethod]
        //[ExpectedException(typeof(UserRegistrationCustomException))]
        public void Given_ValidateMobileNumber_If_Null_ShouldThrow_UserRegistrationCustomException()
        {
            //Arrange
            MobileNumber_Pattern patternMatch = new MobileNumber_Pattern();
            bool expected = true;

            //Act
            //var result = patternMatch.ValidatePhoneNumber(null);
            var result = patternMatch.ValidatePhoneNumber("91 7504832115");

            //Assert
            Assert.AreEqual(expected, result);
        }

        //UC5_6_7_8
        [TestMethod]
        //[ExpectedException(typeof(UserRegistrationCustomException))]
        public void Given_ValidatePassword_If_Null_ShouldThrow_UserRegistrationCustomException()
        {
            //Arrange
            Password_Pattern patternMatch = new Password_Pattern();
            bool expected = true;

            //Act
            //var result = patternMatch.ValidatePassword(null);
            var result = patternMatch.ValidatePassword("Tr5h7$stU");

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}