using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobs.Utilities.Tests
{
    [TestFixture]
    public class Check_ArgumentEmpty_Tests
    {
        [Test]
        public void Throws_ArgumentNullException_For_Null_Argument()
        {
            // Arrange
            string argument = null;

            // Act
            TestDelegate test = () => Check.NotEmpty(argument, "argument");

            // Assert
            Assert.That(
                test,
                Throws
                    .TypeOf<ArgumentNullException>()
                    .With.Property("ParamName")
                    .EqualTo("argument")
                );
        }

        [Test]
        public void Throws_ArgumentException_For_Empty_Argument()
        {
            // Arrange
            string argument = string.Empty;

            // Act
            TestDelegate test = () => Check.NotEmpty(argument, "argument");

            // Assert
            Assert.That(
                test,
                Throws
                    .TypeOf<ArgumentException>()
                    .With.Property("ParamName")
                    .EqualTo("argument")
                );
        }

        [Test]
        public void Returns_Argument_When_Not_NullOrEmpty()
        {
            // Arrange
            string test = "Hello World!";

            // Act
            string result = Check.NotEmpty(test, "test");

            // Assert
            Assert.That(result, Is.EqualTo(test));
        }
    }
}
