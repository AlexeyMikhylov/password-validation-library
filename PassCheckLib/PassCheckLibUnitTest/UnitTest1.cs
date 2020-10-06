using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassCheckLib;

namespace PassCheckLibUnitTest
{
    [TestClass]
    public class PassCheckTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string password = "PassWord123";
            string expected = "ok";
            //act
            PasswordCheckClass passch = new PasswordCheckClass();
            string actual = passch.passLengthCheck(password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string password = "Pass1";
            string expected = "not ok";
            //act
            PasswordCheckClass passch = new PasswordCheckClass();
            string actual = passch.passLengthCheck(password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string password = "password123"; //no uppercase
            string expected = "ненадежный пароль";
            //act
            PasswordCheckClass passch = new PasswordCheckClass();
            string actual = passch.passCheck(password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string password = "PASSWORD123"; //no lowercase
            string expected = "ненадежный пароль";
            //act
            PasswordCheckClass passch = new PasswordCheckClass();
            string actual = passch.passCheck(password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string password = "PassWord"; //no numbers
            string expected = "ненадежный пароль";
            //act
            PasswordCheckClass passch = new PasswordCheckClass();
            string actual = passch.passCheck(password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string password = "PassWord123"; //all yes
            string expected = "Надежный пароль";
            //act
            PasswordCheckClass passch = new PasswordCheckClass();
            string actual = passch.passCheck(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
