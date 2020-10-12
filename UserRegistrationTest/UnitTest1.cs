using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow("Sunny", true)]
        [DataRow("sunny", false)]
        [DataRow("su", false)]
        public void ValidateFirstNameShouldReturnExpectedResult(string firstName, bool expectedResult)
        {
            Validate validate = new Validate();

            bool result = validate.ValidateFirstName(firstName);

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]

        [DataRow("Bunny", true)]
        [DataRow("bunny", false)]
        [DataRow("bu", false)]
        public void ValidateLastNameShouldReturnExpectedResult(string lastName, bool expectedResult)
        {
            Validate validate = new Validate();

            bool result = validate.ValidateFirstName(lastName);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        [DataRow("abc@gmail.com", true)]
        [DataRow("abc@gmail.co.in", true)]
        [DataRow("abc.xyz@gmail.com", true)]
        [DataRow("abc.xyz.pqr@gmail.com", true)]
        [DataRow("abc@gmail.co.in.au", false)]
        [DataRow("abc@.com", false)]
        [DataRow("abcgmail.com", false)]
        [DataRow(".abc@gmail.com", false)]
        public void ValidateEmailShouldReturnExpectedResult(string eMail, bool expectedResult)
        {
            Validate validate = new Validate();

            bool result = validate.ValidateEmail(eMail);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        [DataRow("+98 9823456790", true)]
        [DataRow("12 0876765432", false)]
        [DataRow("769876342135", false)]
        [DataRow("12 587676547", false)]
        public void ValidatePhoneNo_Should_Return_expectedResult(string phoneNo, bool expectedResult)
        {
            Validate validate = new Validate();

            bool result = validate.ValidatePhoneNo(phoneNo);

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]

        [DataRow("ABCab123@", true)]
        [DataRow("abc", false)]
        [DataRow("abcdefgh", false)]
        [DataRow("ABCab@abc", false)]
        [DataRow("abc123ABC", false)]
        [DataRow("abc@ABC12#", false)]
        public void ValidatePassword_Should_Return_expectedResult(string password, bool expectedResult)
        {
            Validate validate = new Validate();

            bool result = validate.ValidatePassword(password);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
