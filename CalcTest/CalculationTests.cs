using System;
using HttpCalcServer;

using NUnit.Framework;

namespace CalcTest
{
    [TestFixture]
    public class CalculationTests
    {
        [TestCase(1, 2, "+", 3)]
        [TestCase(1, 2, "*", 2)]
        [TestCase(1, 2, "-", -1)]
        [TestCase(2, 2, "/", 1)]
        [Test]
        public void funct_calcTest(int a, int b, string op, int exp)
        {
            int res = HttpServer.Calc(a, b, op);
            Assert.AreEqual(exp, res); ;
        }
    }
}
