using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobs.Utilities.Tests
{
    [TestFixture]
    public class Check_NotNull_Tests
    {
        [Test]
        public void Throws_ArgumentNullException_For_Null_Argument()
        {
            string test = null;
            Assert.That(
                () => Check.NotNull(test, "test"),
                Throws
                    .TypeOf<ArgumentNullException>()
                    .With.Property("ParamName")
                    .EqualTo("test")
                );
        }

        [Test]
        public void Returns_Argument_When_Not_Null()
        {
            string test = "Hello World!";
            Assert.That(
                Check.NotNull(test, "test"),
                Is.EqualTo(test)
                );
        }
    }
}
