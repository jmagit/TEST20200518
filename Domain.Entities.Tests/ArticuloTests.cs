using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Tests {
    [TestClass()]
    public class ArticuloTests {
        [TestMethod()]
        public void ArticuloOKTest() {
            var prod = new Producto(1, "Uno", 10);
            var obj = new Articulo(prod);
            Assert.IsNotNull(obj);
            Assert.AreEqual(1, obj.Producto.IdProducto);
            Assert.AreEqual(1, obj.Cantidad);
            Assert.AreEqual(prod.Precio, obj.Precio);
            Assert.AreEqual(0, obj.Descuento);
        }
        [TestMethod()]
        public void ArticuloKOTest() {
            var prod = new Producto(1, "Uno", 10);

            Assert.ThrowsException<CompraException>(() => new Articulo(null));
            Assert.ThrowsException<CompraException>(() => new Articulo(prod, -1));
        }

        [TestMethod()]
        public void CalculosOKTest() {
            var obj = new Articulo(new Producto(1, "Uno", 10), 5);
            Assert.AreEqual(50, obj.ImporteSinDescuento);
            Assert.AreEqual(0, obj.ImporteDescuento);
            Assert.AreEqual(50, obj.Total);
            Assert.AreEqual(0, obj.Descuento);
            Assert.AreEqual(0, obj.Recargo);
            obj.Descuento = 0.10;
            Assert.AreEqual(0, obj.Recargo);
            Assert.AreEqual(5, obj.ImporteDescuento);
            Assert.AreEqual(45, obj.Total);
            obj.Recargo = 0.05;
            Assert.AreEqual(0, obj.Descuento);
            Assert.AreEqual(-2.5, obj.ImporteDescuento);
            Assert.AreEqual(52.5, obj.Total);
            obj.SetRegalo();
            Assert.AreEqual(50, obj.ImporteDescuento);
            Assert.AreEqual(0, obj.Total);
            obj.SetDevolucion();
            Assert.AreEqual(100, obj.ImporteDescuento);
            Assert.AreEqual(-50, obj.Total);
        }

        [TestMethod()]
        public void SetDevolucionTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void SetRegaloTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void AddCantidadTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void RemoveCantidadTest() {
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