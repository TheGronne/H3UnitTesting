using NUnit.Framework;
using ClassLibraryUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryUnitTest.Tests
{
    [TestFixture()]
    public class MathTests
    {
        [Test()]
        public void AddTest()
        {
            int result = new Math().Add(3, 5);
            int expected = 8;
            Assert.That(expected == result);
        }
    }
}