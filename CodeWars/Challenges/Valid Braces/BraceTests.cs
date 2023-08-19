using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.Valid_Braces
{
    [TestFixture]
    public class BraceTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, Brace.validBraces("()"));
        }
        [Test]
        public void Test2()
        {

            Assert.AreEqual(false, Brace.validBraces("[(])"));
        }
    }
}
