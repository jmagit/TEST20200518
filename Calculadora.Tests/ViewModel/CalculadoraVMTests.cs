using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

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
            foreach (var c in numero) {
                switch (c) {
                    case ',':
                        calc.AñadirComaDecimal.Execute();
                        break;
                    case '-':
                        break;
                    default:
                        calc.AñadirDigito.Execute(c);
                        break;
                }
            }
            if (numero[0] == '-') calc.CambiarSigno.Execute();
            Assert.AreEqual(numero, calc.Pantalla);
        }
        private void PonNumero(double numero) {
            PonNumero(numero.ToString());
        }

        private void OperacionHelper(double operando1, char operacion, double operando2, double expect) {
            PonNumero(operando1);
            calc.Operar.Execute(operacion);
            PonNumero(operando2);
            calc.Operar.Execute("=");
            Assert.AreEqual(expect.ToString(), calc.Pantalla);
        }

        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\operaciones.csv", "operaciones#csv", DataAccessMethod.Sequential)]
        public void OperacionTest() {
            OperacionHelper(
                double.Parse(TestContext.DataRow[0].ToString()),
                TestContext.DataRow["operacion"].ToString()[0],
                double.Parse(TestContext.DataRow["operando2"].ToString()),
                double.Parse(TestContext.DataRow["resultado"].ToString()));

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
        }
        [TestMethod]
        public void DivideByCeroTest() {
            OperacionHelper(5, '/', 0, double.PositiveInfinity);
        }


        private static object ExecuteMethod(Object arrange, string metodo, object[] parametros) {
            MethodInfo privado = arrange.GetType().GetMethod(metodo,
                BindingFlags.NonPublic | BindingFlags.Instance);
            return privado.Invoke(arrange, parametros);
        }

        private void Calcula(string nuevaOp) {
            ExecuteMethod(calc, "Calcula", new object[] { nuevaOp });
        }

        [TestMethod]
        public void CalculaTest() {
            Assert.AreEqual("0", calc.Pantalla);
            PonNumero(2);
            Calcula("+");
            Assert.AreEqual("2", calc.Pantalla);
            PonNumero(3);
            Calcula("*");
            Assert.AreEqual("5", calc.Pantalla);
            PonNumero(3);
            Assert.AreEqual("3", calc.Pantalla);
            Calcula("=");
            Assert.AreEqual("15", calc.Pantalla);
        }
    }
}