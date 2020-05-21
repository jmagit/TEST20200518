using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Core;
using Domain.Services;
using Moq;

namespace Domain.Entities.Tests {
    [TestClass()]
    public class CarritoTests {
        [TestMethod()]
        public void ImportesTest() {
            Carrito obj = Carrito3Articulos();
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

        private static Carrito Carrito3Articulos() {
            var obj = new Carrito();
            obj.Add(new Producto(1, "Uno", 2), 10);
            obj.Add(new Producto(2, "Dos", 10), 5);
            obj.Add(new Producto(3, "Tres", 5), 10);
            return obj;
        }

        [TestMethod()]
        public void AddArticuloTest() {
            Carrito obj = Carrito3Articulos();

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

        private static IArticulo NewArticuloStubs(double importeSinDescuento, double importeDescuento) {
            return new Fakes.StubIArticulo() {
                ImporteDescuentoGet = () => importeDescuento,
                ImporteSinDescuentoGet = () => importeSinDescuento
            };
        }
        private static IArticulo NewArticuloStubs2(double importeSinDescuento, double importeDescuento) {
            var mock = new Mock<IArticulo>();
            mock.Setup(o => o.ImporteDescuento).Returns(importeDescuento);
            mock.Setup(o => o.ImporteSinDescuento).Returns(importeSinDescuento);
            return mock.Object;
        }

        private static Carrito Carrito3ArticulosStubs() {
            var obj = new Carrito();

            obj.Add(NewArticuloStubs(10, 2));
            obj.Add(NewArticuloStubs(5, 0));
            obj.Add(NewArticuloStubs(15, 3));
            return obj;
        }


        [TestMethod]
        public void ImporteSinDescuentoTest() {
            var arrage = Carrito3ArticulosStubs();
            var rslt = arrage.ImporteSinDescuento;
            Assert.AreEqual(30, rslt);
        }
        [TestMethod]
        public void ImporteDescuentoTest() {
            var arrage = Carrito3ArticulosStubs();
            var rslt = arrage.ImporteDescuento;
            Assert.AreEqual(5, rslt);
        }

        [TestMethod]
        public void TotalTest() {
            var arrage = Carrito3ArticulosStubs();
            var rslt = arrage.Total;
            Assert.AreEqual(25, rslt);
        }
        [TestMethod]
        public void TotalShimTest() {
            using (Microsoft.QualityTools.Testing.Fakes.ShimsContext.Create()) {
                Fakes.ShimCarrito.AllInstances.ImporteDescuentoGet = (arg) => 10;
                Fakes.ShimCarrito.AllInstances.ImporteSinDescuentoGet = (arg) => 100;
                var arrage = new Carrito();
                var rslt = arrage.Total;
                Assert.AreEqual(90, rslt);
            }
        }

        [TestMethod]
        public void GuardarTest() {
            IRepository<Carrito> repository = new Core.Fakes.StubIRepository<Carrito>() {
                AddT0 = (Carrito item) => item.IdCarrito = 1
            };
            CarritoDomainService srv = new CarritoDomainService(repository);
            Carrito carrito = Carrito3Articulos();
            srv.HacerPedido(carrito);
            Assert.AreEqual(1, carrito.IdCarrito);
        }
        private static IArticulo NewArticuloMock(double importeSinDescuento, double importeDescuento, List<Mock<IArticulo>> lst) {
            var mock = new Mock<IArticulo>();
            mock.Setup(o => o.ImporteDescuento).Returns(importeDescuento);
            mock.Setup(o => o.ImporteSinDescuento).Returns(importeSinDescuento);
            lst.Add(mock);
            return mock.Object;
        }

        private static Carrito Carrito3ArticulosMock(List<Mock<IArticulo>> lst) {
            var obj = new Carrito();
            obj.Add(NewArticuloMock(10, 2, lst));
            obj.Add(NewArticuloMock(5, 0, lst));
            obj.Add(NewArticuloMock(15, 3, lst));
            return obj;
        }
        [TestMethod]
        public void ImporteSinDescuentoMoqTest() {
            List<Mock<IArticulo>> lst = new List<Mock<IArticulo>>();
            var arrage = Carrito3ArticulosMock(lst);
            var rslt = arrage.ImporteSinDescuento;
            Assert.AreEqual(30, rslt);
            foreach(var mock in lst) {
                mock.VerifyGet(o => o.ImporteSinDescuento);
                //mock.VerifyGet(o => o.ImporteDescuento);
            }
        }

    }
}