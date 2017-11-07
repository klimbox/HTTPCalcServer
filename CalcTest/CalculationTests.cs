using System;
using HttpCalcServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest
{
    [TestClass]
    public class CalculationTests
    {
        [DataTestMethod]
        [DataRow(1, 2, "+", 3)]
        [DataRow(1, 2, "*", 2)]
        [DataRow(1, 2, "-", -1)]
        [DataRow(2, 2, "/", 1)]

        [TestMethod()]
        public void funct_calcTest(int a, int b, string op, int exp)
        {
            int res = HttpServer.Calc(a, b, op);
            Assert.AreEqual(exp, res); ;
        }
    }
}
