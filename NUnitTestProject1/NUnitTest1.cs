using System;
using NUnit.Framework;

namespace NUnitTestProject1
{
    //[TestFixture]
    public class NUnitTest1
    {
        //[Test]
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


        internal class ClaseEjemplo
        {
            internal int Sumar(int a, int b)
            {
                return (a + b);
            }
        }
    }
}