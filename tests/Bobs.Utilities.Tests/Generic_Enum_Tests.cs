using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobs.Utilities.Tests
{
    [TestFixture]
    public class Generic_Enum_Tests
    {
        [Test]
        public void GetName_Test()
        {
            Assert.That(Enum<TestEnum>.GetName(TestEnum.Value2), Is.EqualTo("Value2"));
        }
        [Test]
        public void GetNames_Test()
        {
            Assert.That(Enum<TestEnum>.GetNames(), Is.EquivalentTo(new [] { "Value1", "Value2", "Value3" }));
        }
        [Test]
        public void GetUnderlyingType_Test()
        {
            Assert.That(Enum<TestEnum>.GetUnderlyingType(), Is.EqualTo(typeof(short)));
        }
        [Test]
        public void GetValues_Test()
        {
            Assert.That(Enum<TestEnum>.GetValues(), Is.EquivalentTo(new[] { TestEnum.Value1, TestEnum.Value2, TestEnum.Value3 }));
        }
        [Test]
        public void IsDefined_Test()
        {
            Assert.That(Enum<TestEnum>.IsDefined(TestEnum.Value2), Is.True);
            Assert.That(Enum<TestEnum>.IsDefined((short)4), Is.False);
        }
        [Test]
        public void Parse_Test()
        {
            Assert.That(Enum<TestEnum>.Parse("Value2", false), Is.EqualTo(TestEnum.Value2));
            Assert.That(Enum<TestEnum>.Parse("value2", true),  Is.EqualTo(TestEnum.Value2));
        }
        [Test]
        public void ToEnum_Test()
        {
            Assert.That(Enum<TestEnum>.ToEnum((short)2), Is.EqualTo(TestEnum.Value3));
        }
    }
}
