﻿/*
 * Created by SharpDevelop.
 * User: lextm
 * Date: 2010/12/4
 * Time: 17:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using Xunit;

namespace CeeSharp.SnmpLib.Unit
{
    public class ScopeTestFixture
    {
        [Fact]
        public void TestException()
        {
            Assert.Throws<ArgumentNullException>(() => new Scope((ISnmpPdu)null));
            Assert.Throws<ArgumentNullException>(() => new Scope((Sequence)null));
            Assert.Throws<ArgumentNullException>(() => new Scope(null, null, null));
            Assert.Throws<ArgumentNullException>(() => new Scope(OctetString.Empty, null, null));
            Assert.Throws<ArgumentNullException>(() => new Scope(OctetString.Empty, OctetString.Empty, null));
        }
    }
}
