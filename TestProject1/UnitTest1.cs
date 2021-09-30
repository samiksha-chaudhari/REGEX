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
       /*
        public void TestFirstName()
        {
            bool result = pattern.validateFirstName("Samiksha");
            Assert.IsTrue(result);
        }
       */

        public void FirstName_ShouldThrow_Exception()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.validateFirstName(null));
            }
            catch (UserRegiException e)
            {
                Assert.AreEqual("Invalid FirstName", e.Message);

            }
        }

        /// <summary>
        /// Tests the last name
        /// </summary>
        [TestMethod]
        /*
        public void TestLastName()
        {
            bool result1 = pattern.validateLastName("Chaudhari");
            Assert.IsTrue(result1);
        }
        */
        public void LastName_ShouldThrow_Exception()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.validateLastName(null));
            }
            catch (UserRegiException e)
            {
                Assert.AreEqual("Invalid LastName", e.Message);

            }
        }


        /// <summary>
        /// Tests the Email ID
        /// </summary>
        [TestMethod]
        /*
        public void TestEmail()
        {
            bool result2 = pattern.validateEmailId("spchaudhari80@gmail.com");
            Assert.IsTrue(result2);
        }
        */

        public void EmailId_ShouldThrow_Exception()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.validateEmailId(null));
            }
            catch (UserRegiException e)
            {
                Assert.AreEqual("Invalid EmailId", e.Message);

            }
        }


        /// <summary>
        /// Tests the mobile number
        /// </summary>
        [TestMethod]
        /*
        public void TestMobileNumber()
        {
            bool result3 = pattern.validatePhoneNumber("9862583253");
            Assert.IsTrue(result3);
        }
        */
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
        }

        /// <summary>
        /// Test passwords
        /// </summary>
        [TestMethod]
        /*
        public void Testpassword()
        {
            bool result4 = pattern.validatePassWord("Samik@chau80");
            Assert.IsTrue(result4);
        }
        */
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

    }
}
