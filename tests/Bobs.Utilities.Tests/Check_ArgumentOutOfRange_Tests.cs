using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobs.Utilities.Tests
{
    [TestFixture]
    class Check_ArgumentOutOfRange_Tests
    {
        [Test]
        public void Throws_ArgumentOutOfRangeException_For_FalseCondition()
        {
            // Arrange
            int argument = 25;

            // Act
            TestDelegate test = () => Check.That(argument < 20, "argument", "Parameter 'argument' has to be smaller than 20");

            // Assert
            Assert.That(
                test,
                Throws
                    .TypeOf<ArgumentOutOfRangeException>()
                    .With.Property("ParamName")
                    .EqualTo("argument")
                );
        }

        [Test]
        public void Throws_ArgumentOutOfRangeException_For_FalsePredicate()
        {
            // Arrange
            int argument = 25;

            // Act
            TestDelegate test = () => Check.That(() => argument < 20, "argument", "Parameter 'argument' has to be smaller than 20");

            // Assert
            Assert.That(
                test,
                Throws
                    .TypeOf<ArgumentOutOfRangeException>()
                    .With.Property("ParamName")
                    .EqualTo("argument")
                );
        }

        [Test]
        public void Does_Not_Throw_For_TrueCondition()
        {
            // Arrange
            int argument = 15;

            // Act
            TestDelegate test = () => Check.That(argument < 20, "argument", "Parameter 'argument' has to be smaller than 20!");

            // Assert
            Assert.That(
                test,
                Throws
                    .Nothing
                );
        }

        [Test]
        public void Does_Not_Throw_For_TruePredicate()
        {
            // Arrange
            int argument = 15;

            // Act
            TestDelegate test = () => Check.That(() => argument < 20, "argument", "Parameter 'argument' has to be smaller than 20!");

            // Assert
            Assert.That(
                test,
                Throws
                    .Nothing
                );
        }
    }
}
