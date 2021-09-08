using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicUnitTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_1and2_3_return()
        {
            // arrange
            int x = 1;
            int y = 2;
            int expected = 3;

            // act
            TestClass1 c = new TestClass1();
            int actual = c.Sum(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
