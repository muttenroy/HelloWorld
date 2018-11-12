using System;
using NUnit.Framework;
using HelloWorld.Controllers;

namespace HelloWorld.Tests
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void Sumar()
        {

            var calculadora = new Calculadora();

            var resultado = calculadora.Sumar(1, 2);

            Assert.AreEqual(3, resultado);

        }
    }
}