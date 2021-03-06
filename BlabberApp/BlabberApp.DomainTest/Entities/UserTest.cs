using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain.Entities;

namespace BlabberApp.DomainTest.Entities
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestSetGetEmail_Success()
        {
            // Arrange
            User harness = new User(); 
            string expected = "foobar@example.com";
            harness.ChangeEmail("foobar@example.com");
            // Act
            string actual = harness.Email; // Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }
        [TestMethod]
        public void TestSetGetEmail_Fail00()
        {
            // Arrange
            User harness = new User();
            string email = "Foobar";
            // Act
            var ex = Assert.ThrowsException<FormatException>(() => harness.ChangeEmail(email));
            // Assert
            Assert.AreEqual($"{email} is invalid", ex.Message.ToString());
        }
        [TestMethod]
        public void TestSetGetEmail_Fail01()
        {
            // Arrange
            User harness = new User();
            string email = "example.com";
            // Act
            var ex = Assert.ThrowsException<FormatException>(() => harness.ChangeEmail(email));
            // Assert
            Assert.AreEqual($"{email} is invalid", ex.Message.ToString());
        }
        [TestMethod]
        public void TestSetGetEmail_Fail02()
        {
            // Arrange
            User harness = new User();
            string email = "foobar.example";
            // Act
            var ex = Assert.ThrowsException<FormatException>(() => harness.ChangeEmail(email));
            // Assert
            Assert.AreEqual($"{email} is invalid", ex.Message.ToString());
        }
        [TestMethod]
        public void TestId()
        {
            // Arrange
            User harness = new User();
            Guid expected = harness.Id;
            // Act
            Guid actual = harness.Id;
            // Assert
            Assert.AreEqual(actual, expected);
            //Assert.AreEqual(true, harness.Id is Guid);
        }
    }
}
