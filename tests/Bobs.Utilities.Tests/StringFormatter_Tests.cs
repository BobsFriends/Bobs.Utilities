using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobs.Utilities.Tests
{
    [TestFixture]
    public class StringFormatter_Tests
    {
        [Test]
        public void StringFormatter_With_All_Parameters()
        {
            // Arrange
            StringFormatter formatter = new StringFormatter(CultureInfo.InvariantCulture, "Hello {0}!", "World");

            // Act
            string result = formatter.ToString();

            // Assert
            Assert.That(result, Is.EqualTo("Hello World!"));
        }

        [Test]
        public void StringFormatter_Without_Arguments()
        {
            // Arrange
            StringFormatter formatter = new StringFormatter(CultureInfo.InvariantCulture, "Hello {0}!", null);

            // Act
            string result = formatter.ToString();

            // Assert
            Assert.That(result, Is.EqualTo("Hello {0}!"));
        }

        [Test]
        public void StringFormatter_Without_Format()
        {
            // Arrange
            StringFormatter formatter = new StringFormatter(CultureInfo.InvariantCulture, null, "World");

            // Act
            string result = formatter.ToString();

            // Assert
            Assert.That(result, Is.Null);
        }
    }
}
