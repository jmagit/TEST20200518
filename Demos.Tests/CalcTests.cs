using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Tests {
    [TestClass()]
    public class CalcTests {
        Calc calc;

        [TestInitialize]
        void TestInitialize() {
            calc = new Calc();
        }
        [TestMethod()]
        public void sumaTest() {
            var obj = new Calc();
            Assert.AreEqual(4, obj.suma(2, 2));
            Assert.AreEqual(double.NaN, double.PositiveInfinity * 0);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void divideTest() {
            var obj = new Calc();
            Assert.AreEqual(2, obj.divide(2, 1));
        }
    }
}