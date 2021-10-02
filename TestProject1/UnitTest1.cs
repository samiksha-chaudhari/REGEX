using Microsoft.VisualStudio.TestTools.UnitTesting;
using REGEX_User_Registration;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Patterns pattern = new Patterns();
        /// <summary>
        /// Tests the first name
        /// </summary>
        [TestMethod]
       
        public void TestFirstName()
        {
            bool result = pattern.ValidateFirstName("Samiksha", Patterns.REGEX_FIRSTNAME);
            Assert.IsTrue(result);
        }
       
        /*
        public void FirstName_ShouldThrow_Exception()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.ValidateFirstName(null));
            }
            catch (UserRegiException e)
            {
                Assert.AreEqual("Invalid FirstName", e.Message);

            }
        }
        */
        /// <summary>
        /// Tests the last name
        /// </summary>
        [TestMethod]
        
        public void TestLastName()
        {
            bool result = pattern.ValidateLastName("Chaudhari", Patterns.REGEX_LASTNAME);
            Assert.IsTrue(result);
        }
        /*
        public void LastName_ShouldThrow_Exception()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.ValidateLastName(null));
            }
            catch (UserRegiException e)
            {
                Assert.AreEqual("Invalid LastName", e.Message);

            }
        }
        */

        /// <summary>
        /// Tests the Email ID
        /// </summary>
        [TestMethod]
        
        public void TestEmail()
        {
            bool result = pattern.ValidateEmail("spchaudhari80@gmail.com", Patterns.REGEX_EMAILID);
            Assert.IsTrue(result);
        }
        
        /*
        public void EmailId_ShouldThrow_Exception()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.alidateEmailId(null));
            }
            catch (UserRegiException e)
            {
                Assert.AreEqual("Invalid EmailId", e.Message);

            }
        }*/


        /// <summary>
        /// Tests the mobile number
        /// </summary>
        [TestMethod]
        
        public void TestMobileNumber()
        {
            bool result = pattern.ValidatePhoneNum("91 9123456789", Patterns.REGEX_PHONENUMBER);
            Assert.IsTrue(result);
        }
        /*
        public void MobileNumber_ShouldThrow_Exception()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.validatePhoneNumber(null));
            }
            catch (UserRegiException e)
            {
                Assert.AreEqual("Invalid PhoneNumber", e.Message);

            }
        }*/

        /// <summary>
        /// Test passwords
        /// </summary>
        [TestMethod]
        
        public void Testpassword()
        {
            bool result = pattern.ValidatePassword("RAw@#5856", Patterns.REGEX_PASSWORD);
            Assert.IsTrue(result);
        }
        /*
        public void Password_ShouldThrow_Exception()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.validatePassWord(null));
            }
            catch (UserRegiException e)
            {
                Assert.AreEqual("Invalid PassWord", e.Message);

            }
        }
        */
    }
}
