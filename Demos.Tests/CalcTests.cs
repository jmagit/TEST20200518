using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Demos.Tests {
    [TestClass()]
    public class CalcTests {
        public TestContext TestContext { get; set; }

        Calc calc;

        [TestInitialize]
        public void TestInitialize() {
            calc = new Calc();
        }

        [TestCleanup]
        public void TestCleanup() {
            var nom = TestContext.TestName;

        }
        [TestMethod()]
        [TestCategory("Humo")]
        [Priority(1)]
        public void sumaTest() {
            var obj = new Calc();
            Assert.AreEqual(4, obj.suma(2, 2));
            Assert.AreEqual(double.NaN, double.PositiveInfinity * 0);
        }

        [TestMethod()]
        [TestCategory("Humo")]
        [Priority(2)]
        //[Timeout(1)]
        public void Multiplica() {
            var rslt = calc.multiplica(2, 3);
            Assert.IsNotNull(rslt);
            Assert.AreEqual(6, rslt);
            Assert.IsTrue(1 < rslt, "Menor 1");
            Assert.IsTrue(rslt <= 6, "Mayor 6");
            // calc.divide(2, 0);
            // Assert.Fail("Por todas estas cosas");
            // Assert.Inconclusive("Que me queda por hacer.");

        }

        [TestMethod()]
        [TestCategory("Excepcion")]
        //[Ignore]
        [ExpectedException(typeof(DivideByZeroException))]
        [Priority(3)]
        public void divideTest() {
            var obj = new Calc();
            Assert.AreEqual(2, obj.divide(2, 0));
        }


        public void AreaTestHelper(double radio, double expected) {
            var arrange = new Calc();
            Assert.AreEqual(expected, Math.Round(arrange.Area(radio), 4));
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\AreaTest.csv", "AreaTest#csv", DataAccessMethod.Sequential)]
        public void AreaTest() {
            AreaTestHelper(double.Parse(TestContext.DataRow[0].ToString()),
                double.Parse(TestContext.DataRow["area"].ToString()));
        }

        [TestMethod]
        [DataRow(1, 6.2832)]
        [DataRow(0, 0)]
        [DataRow(0.5, 3.1416)]
        public void AreaDataTest(double radio, double expected) {
            var arrange = new Calc();
            Assert.AreEqual(expected, Math.Round(arrange.Area(radio), 4));
        }

        [TestMethod]
        public void moqTest() {
            var mock = new Mock<ICalc>();
            mock.Setup(c => c.suma(It.IsAny<double>(), It.IsAny<double>())).Returns(100);
            mock.Setup(c => c.suma(2, 2)).Returns(4).Verifiable();
            mock.Setup(c => c.suma(2, 4)).Returns(6);
            mock.Setup(c => c.divide(It.IsAny<double>(), 0)).Throws(new DivideByZeroException("Infinito")).Verifiable();

            var calc = mock.Object;

            //Assert.AreEqual(4, calc.suma(2, 2));
            //Assert.AreEqual(6, calc.suma(2, 4));
            Assert.AreEqual(100, calc.suma(1, 3));
            Assert.AreEqual(0, calc.divide(2, 2));
            //Assert.ThrowsException<DivideByZeroException>(() => calc.divide(2, 0));
            //mock.Verify(c => c.suma(2, 4));
            mock.Verify();
        }

        [TestMethod]
        public void moqTest2() {
            var mock = new Mock<ICalc>();
            mock.Setup(c => c.suma(It.IsAny<double>(), It.IsAny<double>())).Returns((double a, double b) => a);
            Assert.AreEqual(2, mock.Object.suma(2, 7));
            mock.SetupSequence(c => c.divide(It.IsAny<double>(), It.IsAny<double>()))
                .Returns(1).Returns(2).Returns(3).Throws<IndexOutOfRangeException>();
            Assert.AreEqual(1, mock.Object.divide(2, 7));
            Assert.AreEqual(2, mock.Object.divide(1, 2));
            Assert.AreEqual(3, mock.Object.divide(3, 4));
            Assert.AreEqual(0, mock.Object.divide(2, 7));



        }

    }
}