using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos.Tests {
    [TestClass]
    public class ValidacionesTest {
        [TestMethod]
        [DataRow("-1")]
        [DataRow("0")]
        [DataRow("0,6")]
        [DataRow("1234")]
        public void IsNumericTest(string valor) {
            var obj = new Demos.Validaciones();
            bool rslt = obj.IsNumeric(valor);
            Assert.IsTrue(rslt);
        }
        [TestMethod]
        public void IsNotNumericTest() {
            var obj = new Demos.Validaciones();
            bool rslt = !obj.IsNumeric("XXXX");
            Assert.IsTrue(rslt);
        }
    }
}
