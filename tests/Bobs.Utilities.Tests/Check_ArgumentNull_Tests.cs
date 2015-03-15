using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobs.Utilities.Tests
{
    [TestFixture]
    public class Check_ArgumentNull_Tests
    {
        [Test]
        public void Throws_ArgumentNullException_For_Null_Argument()
        {
            // Arrange
            string argument = null;

            // Act
            TestDelegate test = () => Check.NotNull(argument, "argument");

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
        public void Returns_Argument_When_Not_Null()
        {
            // Arrange
            string test = "Hello World!";

            // Act
            string result = Check.NotNull(test, "test");

            // Assert
            Assert.That(result, Is.EqualTo(test));
        }
    }
}
