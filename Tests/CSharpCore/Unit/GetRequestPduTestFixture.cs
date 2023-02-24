﻿using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace CeeSharp.SnmpLib.Unit
{
    public class GetRequestPduTestFixture
    {
        [Fact]
        public void TestException()
        {
            Assert.Throws<ArgumentNullException>(() => new GetRequestPdu(new Tuple<int, byte[]>(0, new byte[] { 0 }), null, false));
            Assert.Throws<ArgumentNullException>(() => new GetRequestPdu(0, null));
            Assert.Throws<ArgumentNullException>(() => new GetRequestPdu(0, new List<Variable>()).AppendBytesTo(null));
            Assert.Throws<ArgumentNullException>(() => new GetRequestPdu(null, new MemoryStream(), false));
        }

        [Fact]
        public void TestConstructor()
        {
            var pdu = new GetRequestPdu(0, new List<Variable>());
            Assert.Equal("GET request PDU: seq: 0; status: 0; index: 0; variable count: 0", pdu.ToString());
        }
    }
}
