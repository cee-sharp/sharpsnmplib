using System;
using Xunit;

namespace CeeSharp.SnmpLib.Unit
{
    public class SnmpDataExtensionTestFixture
    {
        [Fact]
        public void TestException()
        {
            Assert.Throws<ArgumentNullException>(() => SnmpDataExtension.ToBytes(null));
        }
    }
}
