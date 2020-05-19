using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Tests {
    [TestClass()]
    public class CarritoTests {
        [TestMethod()]
        public void ImportesTest() {
            var obj = new Carrito();
            obj.Add(new Producto(1, "Uno", 2), 10);
            obj.Add(new Producto(2, "Dos", 10), 5);
            obj.Add(new Producto(3, "Tres", 5), 10);
            Assert.AreEqual(3, obj.Articulos.Count);
            Assert.AreEqual(3, obj.NumeroLineas);
            Assert.AreEqual(120, obj.ImporteSinDescuento);
            Assert.AreEqual(0, obj.ImporteDescuento);
            Assert.AreEqual(120, obj.Total);
            var art = new Articulo(new Producto(4, "Cuatro", 10), 5);
            art.SetRegalo();
            obj.Add(art);
            Assert.AreEqual(4, obj.NumeroLineas);
            Assert.AreEqual(120, obj.Total);
            art.Descuento = 0.10;
            Assert.AreEqual(5, obj.ImporteDescuento);
            Assert.AreEqual("Cuatro", obj.Articulos[3].Producto.Nombre);
            obj.Articulos[3].SetRegalo();
            Assert.AreEqual(5, obj.ImporteDescuento);
            art.Producto.Precio = 0;
        }

        [TestMethod()]
        public void AddArticuloTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void AddProductoTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void AddCantidadIndiceTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void AddCantidadProductoTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void RemoveCantidadIndiceTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void RemoveCantidadProductoTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void RemoveTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void ClearTest() {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void CalculaRecargoTest() {
            Assert.Inconclusive();
        }
    }
}