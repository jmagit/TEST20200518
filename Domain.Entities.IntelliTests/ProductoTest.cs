using System;
using Domain.Entities;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Entities.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para Producto</summary>
    [TestClass]
    [PexClass(typeof(Producto))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProductoTest
    {

        /// <summary>Código auxiliar de prueba para .ctor(Int32, String, Double, Estado)</summary>
        [PexMethod]
        public Producto ConstructorTest(
            int idProducto,
            string nombre,
            double precio,
            Estado estado
        ) {
            Producto target = new Producto(idProducto, nombre, precio, estado);
            return target;
            // TODO: agregar aserciones a método ProductoTest.ConstructorTest(Int32, String, Double, Estado)
        }

        /// <summary>Código auxiliar de prueba para Clone()</summary>
        [PexMethod]
        public object CloneTest([PexAssumeUnderTest]Producto target) {
            object result = target.Clone();
            return result;
            // TODO: agregar aserciones a método ProductoTest.CloneTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para Descatalogar()</summary>
        [PexMethod]
        public void DescatalogarTest([PexAssumeUnderTest]Producto target) {
            target.Descatalogar();
            // TODO: agregar aserciones a método ProductoTest.DescatalogarTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para Equals(Object)</summary>
        [PexMethod]
        public bool EqualsTest([PexAssumeUnderTest]Producto target, object obj) {
            bool result = target.Equals(obj);
            return result;
            // TODO: agregar aserciones a método ProductoTest.EqualsTest(Producto, Object)
        }

        /// <summary>Código auxiliar de prueba para GetHashCode()</summary>
        [PexMethod]
        public int GetHashCodeTest([PexAssumeUnderTest]Producto target) {
            int result = target.GetHashCode();
            return result;
            // TODO: agregar aserciones a método ProductoTest.GetHashCodeTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para Recatalogar(Double)</summary>
        [PexMethod]
        public void RecatalogarTest([PexAssumeUnderTest]Producto target, double precio) {
            target.Recatalogar(precio);
            // TODO: agregar aserciones a método ProductoTest.RecatalogarTest(Producto, Double)
        }

        /// <summary>Código auxiliar de prueba para SetConStock()</summary>
        [PexMethod]
        public void SetConStockTest([PexAssumeUnderTest]Producto target) {
            target.SetConStock();
            // TODO: agregar aserciones a método ProductoTest.SetConStockTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para SetSinStock()</summary>
        [PexMethod]
        public void SetSinStockTest([PexAssumeUnderTest]Producto target) {
            target.SetSinStock();
            // TODO: agregar aserciones a método ProductoTest.SetSinStockTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para ToString()</summary>
        [PexMethod]
        public string ToStringTest([PexAssumeUnderTest]Producto target) {
            string result = target.ToString();
            return result;
            // TODO: agregar aserciones a método ProductoTest.ToStringTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para get_Estado()</summary>
        [PexMethod]
        public Estado EstadoGetTest([PexAssumeUnderTest]Producto target) {
            Estado result = target.Estado;
            return result;
            // TODO: agregar aserciones a método ProductoTest.EstadoGetTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para get_IdProducto()</summary>
        [PexMethod]
        public int IdProductoGetTest([PexAssumeUnderTest]Producto target) {
            int result = target.IdProducto;
            return result;
            // TODO: agregar aserciones a método ProductoTest.IdProductoGetTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para get_IsDescatalogado()</summary>
        [PexMethod]
        public bool IsDescatalogadoGetTest([PexAssumeUnderTest]Producto target) {
            bool result = target.IsDescatalogado;
            return result;
            // TODO: agregar aserciones a método ProductoTest.IsDescatalogadoGetTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para get_Nombre()</summary>
        [PexMethod]
        public string NombreGetTest([PexAssumeUnderTest]Producto target) {
            string result = target.Nombre;
            return result;
            // TODO: agregar aserciones a método ProductoTest.NombreGetTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para get_Precio()</summary>
        [PexMethod]
        public double PrecioGetTest([PexAssumeUnderTest]Producto target) {
            double result = target.Precio;
            return result;
            // TODO: agregar aserciones a método ProductoTest.PrecioGetTest(Producto)
        }

        /// <summary>Código auxiliar de prueba para set_IdProducto(Int32)</summary>
        [PexMethod]
        public void IdProductoSetTest([PexAssumeUnderTest]Producto target, int value) {
            target.IdProducto = value;
            // TODO: agregar aserciones a método ProductoTest.IdProductoSetTest(Producto, Int32)
        }

        /// <summary>Código auxiliar de prueba para set_Nombre(String)</summary>
        [PexMethod]
        public void NombreSetTest([PexAssumeUnderTest]Producto target, string value) {
            target.Nombre = value;
            // TODO: agregar aserciones a método ProductoTest.NombreSetTest(Producto, String)
        }

        /// <summary>Código auxiliar de prueba para set_Precio(Double)</summary>
        [PexMethod]
        public void PrecioSetTest([PexAssumeUnderTest]Producto target, double value) {
            target.Precio = value;
            // TODO: agregar aserciones a método ProductoTest.PrecioSetTest(Producto, Double)
        }
    }
}
