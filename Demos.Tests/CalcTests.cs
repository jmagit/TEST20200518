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
        public void TestInitialize() {
            calc = new Calc();
        }
        [TestMethod()]
        public void sumaTest() {
            var obj = new Calc();
            Assert.AreEqual(4, obj.suma(2, 2));
            Assert.AreEqual(double.NaN, double.PositiveInfinity * 0);
        }

        [TestMethod()]
        [Timeout(1)]
        public void Multiplica() {
            var rslt = calc.multiplica(2, 3);
            Assert.IsNotNull(rslt);
            Assert.AreEqual(6, rslt);
            Assert.IsTrue(1 < rslt, "Menor 1");
            Assert.IsTrue(rslt <= 6, "Mayor 6");
            // calc.divide(2, 0);
            // Assert.Fail("Por todas estas cosas");
            Assert.Inconclusive("Que me queda por hacer.");

        }

        [TestMethod()]
        [Ignore]
        [ExpectedException(typeof(DivideByZeroException))]
        public void divideTest() {
            var obj = new Calc();
            Assert.AreEqual(2, obj.divide(2, 1));
        }
    }
}