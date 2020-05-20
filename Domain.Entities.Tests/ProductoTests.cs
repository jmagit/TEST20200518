using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Tests {
    [TestClass()]
    public class ProductoTests {
        [TestMethod()]
        public void ProductoOKTest() {
            var obj = new Producto(1, "Uno", 10);
            Assert.IsNotNull(obj);
            Assert.AreEqual(1, obj.IdProducto);
            Assert.AreEqual("Uno", obj.Nombre);
            Assert.AreEqual(10, obj.Precio);
            Assert.AreEqual(Estado.ConStock, obj.Estado);
        }

        [TestMethod()]
        // [ExpectedException(typeof(CompraException))]
        public void ProductoKOTest() {
            Producto obj;
            Assert.ThrowsException<CompraException>(() => obj = new Producto(-1, null, 10), "Id negativo");
            Assert.ThrowsException<CompraException>(() => obj = new Producto(1, null, 10), "Nombre nulo");
            Assert.ThrowsException<CompraException>(() => obj = new Producto(1, "", 10), "Nombre en blanco");
            Assert.ThrowsException<CompraException>(() => obj = new Producto(1, "xxx", 0), "Precio 0");
        }

        [TestMethod()]
        public void SetConStockTest() {
            var obj = new Producto(1, "Uno", 10, Estado.SinStock);
            Assert.AreEqual(Estado.SinStock, obj.Estado);
            obj.SetConStock();
            Assert.AreEqual(Estado.ConStock, obj.Estado);
        }

        [TestMethod()]
        public void SetSinStockTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void DescatalogarOKTest() {
            var obj = new Producto(1, "Uno", 10, Estado.SinStock);
            obj.Descatalogar();
            Assert.AreEqual(Estado.Descatalogado, obj.Estado);
            obj.Recatalogar(10);
            Assert.AreEqual(Estado.ConStock, obj.Estado);
        }
        [TestMethod()]
        public void DescatalogarKOTest() {
            var obj = new Producto(1, "Uno", 10, Estado.SinStock);
            obj.Descatalogar();
            Assert.ThrowsException<CompraException>(() => obj.Descatalogar());
            obj.Recatalogar(10);
            Assert.ThrowsException<CompraException>(() => obj.Recatalogar(10));
        }
        [TestMethod()]
        [ExpectedException(typeof(CompraException))]
        public void DescatalogarKO2Test() {
            var obj = new Producto(1, "Uno", 10, Estado.SinStock);
            obj.Descatalogar();
            obj.Descatalogar();
            obj.Recatalogar(10); // Mal, no se ejecuta
            obj.Recatalogar(10);
        }

        [TestMethod()]
        public void RecatalogarTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void EqualsTest() {
            var obj = new Producto(1, "Uno", 10);
            Assert.IsTrue(obj.Equals(new Producto(1, "Uno", 10)));
            Assert.IsFalse(obj.Equals(new Producto(2, "Uno", 10)));
            Assert.IsFalse(obj.Equals(null));
        }

        [TestMethod()]
        public void GetHashCodeTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void ToStringTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void CloneTest() {
            Assert.Inconclusive();
        }
    }
}