using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ViewModel.Tests {
    [TestClass()]
    public class CalculadoraVMTests {
        CalculadoraVM calc = new CalculadoraVM();

        [TestMethod()]
        public void AñadirDigitoTest() {
            calc.AñadirDigito.Execute("1");
            Assert.AreEqual("1", calc.Pantalla);
            calc.AñadirDigito.Execute("2");
            Assert.AreEqual("12", calc.Pantalla);
            calc.Borrar.Execute();
            Assert.AreEqual("1", calc.Pantalla);
            calc.Borrar.Execute();
            Assert.AreEqual("0", calc.Pantalla);
            calc.Borrar.Execute();
            Assert.AreEqual("0", calc.Pantalla);
        }

        private void PonNumero(string numero) {
            foreach(var c in numero) {
                calc.AñadirDigito.Execute(c);
            }
            Assert.AreEqual(numero, calc.Pantalla);
        }

        private void OperacionHelper(double operando1, char operacion, double operando2, double expect) {
            PonNumero(operando1.ToString());
            calc.Operar.Execute(operacion);
            PonNumero(operando2.ToString());
            calc.Operar.Execute("=");
            Assert.AreEqual(expect.ToString(), calc.Pantalla);
        }
        [TestMethod]
        public void SumaTest() {
            OperacionHelper(2, '+', 2, 4);
            OperacionHelper(5, '+', 1, 6);
        }
        [TestMethod]
        public void RestaTest() {
            OperacionHelper(2, '-', 2, 0);
            OperacionHelper(5, '-', 1, 4);
        }
        [TestMethod]
        public void MultiplicaTest() {
            OperacionHelper(25, '*', 10, 250);
            OperacionHelper(5, '*', 1, 5);
        }
        [TestMethod]
        public void DivideTest() {
            OperacionHelper(25, '/', 10, 2.5);
            OperacionHelper(5, '/', 0, double.PositiveInfinity);
        }
    }
}