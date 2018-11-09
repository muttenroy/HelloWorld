using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void SumarTest()
        {
            ClaseEjemplo target = new ClaseEjemplo();
            int a = 1;
            int b = 2;
            int expected = 3;
            int actual;
            actual = target.Sumar(a, b);
            Assert.AreEqual(expected, actual);
        }
    }

    internal class ClaseEjemplo
    {
        internal int Sumar(int a, int b)
        {
            return (a + b);
        }
    }
}
