using System;
using Domain.Entities;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Entities.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para Articulo</summary>
    [TestClass]
    [PexClass(typeof(Articulo))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ArticuloTest
    {

        /// <summary>Código auxiliar de prueba para .ctor(IProducto)</summary>
        [PexMethod]
        public Articulo ConstructorTest(IProducto producto) {
            Articulo target = new Articulo(producto);
            return target;
            // TODO: agregar aserciones a método ArticuloTest.ConstructorTest(IProducto)
        }

        /// <summary>Código auxiliar de prueba para .ctor(IProducto, Int32)</summary>
        [PexMethod]
        public Articulo ConstructorTest01(IProducto producto, int cantidad) {
            Articulo target = new Articulo(producto, cantidad);
            return target;
            // TODO: agregar aserciones a método ArticuloTest.ConstructorTest01(IProducto, Int32)
        }

        /// <summary>Código auxiliar de prueba para .ctor(IProducto, Int32, Double)</summary>
        [PexMethod]
        public Articulo ConstructorTest02(
            IProducto producto,
            int cantidad,
            double descuento
        ) {
            Articulo target = new Articulo(producto, cantidad, descuento);
            return target;
            // TODO: agregar aserciones a método ArticuloTest.ConstructorTest02(IProducto, Int32, Double)
        }

        /// <summary>Código auxiliar de prueba para AddCantidad(Int32)</summary>
        [PexMethod]
        public int AddCantidadTest([PexAssumeUnderTest]Articulo target, int cantidad) {
            int result = target.AddCantidad(cantidad);
            return result;
            // TODO: agregar aserciones a método ArticuloTest.AddCantidadTest(Articulo, Int32)
        }

        /// <summary>Código auxiliar de prueba para Clone()</summary>
        [PexMethod]
        public object CloneTest([PexAssumeUnderTest]Articulo target) {
            object result = target.Clone();
            return result;
            // TODO: agregar aserciones a método ArticuloTest.CloneTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para RemoveCantidad(Int32)</summary>
        [PexMethod]
        public int RemoveCantidadTest([PexAssumeUnderTest]Articulo target, int cantidad) {
            int result = target.RemoveCantidad(cantidad);
            return result;
            // TODO: agregar aserciones a método ArticuloTest.RemoveCantidadTest(Articulo, Int32)
        }

        /// <summary>Código auxiliar de prueba para SetDevolucion()</summary>
        [PexMethod]
        public void SetDevolucionTest([PexAssumeUnderTest]Articulo target) {
            target.SetDevolucion();
            // TODO: agregar aserciones a método ArticuloTest.SetDevolucionTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para SetRegalo()</summary>
        [PexMethod]
        public void SetRegaloTest([PexAssumeUnderTest]Articulo target) {
            target.SetRegalo();
            // TODO: agregar aserciones a método ArticuloTest.SetRegaloTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para ToString()</summary>
        [PexMethod]
        public string ToStringTest([PexAssumeUnderTest]Articulo target) {
            string result = target.ToString();
            return result;
            // TODO: agregar aserciones a método ArticuloTest.ToStringTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para get_Cantidad()</summary>
        [PexMethod]
        public int CantidadGetTest([PexAssumeUnderTest]Articulo target) {
            int result = target.Cantidad;
            return result;
            // TODO: agregar aserciones a método ArticuloTest.CantidadGetTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para get_Descuento()</summary>
        [PexMethod]
        public double DescuentoGetTest([PexAssumeUnderTest]Articulo target) {
            double result = target.Descuento;
            return result;
            // TODO: agregar aserciones a método ArticuloTest.DescuentoGetTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para get_ImporteDescuento()</summary>
        [PexMethod]
        public double ImporteDescuentoGetTest([PexAssumeUnderTest]Articulo target) {
            double result = target.ImporteDescuento;
            return result;
            // TODO: agregar aserciones a método ArticuloTest.ImporteDescuentoGetTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para get_ImporteSinDescuento()</summary>
        [PexMethod]
        public double ImporteSinDescuentoGetTest([PexAssumeUnderTest]Articulo target) {
            double result = target.ImporteSinDescuento;
            return result;
            // TODO: agregar aserciones a método ArticuloTest.ImporteSinDescuentoGetTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para get_IsDevolucion()</summary>
        [PexMethod]
        public bool IsDevolucionGetTest([PexAssumeUnderTest]Articulo target) {
            bool result = target.IsDevolucion;
            return result;
            // TODO: agregar aserciones a método ArticuloTest.IsDevolucionGetTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para get_IsRegalo()</summary>
        [PexMethod]
        public bool IsRegaloGetTest([PexAssumeUnderTest]Articulo target) {
            bool result = target.IsRegalo;
            return result;
            // TODO: agregar aserciones a método ArticuloTest.IsRegaloGetTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para get_Precio()</summary>
        [PexMethod]
        public double PrecioGetTest([PexAssumeUnderTest]Articulo target) {
            double result = target.Precio;
            return result;
            // TODO: agregar aserciones a método ArticuloTest.PrecioGetTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para get_Producto()</summary>
        [PexMethod]
        public IProducto ProductoGetTest([PexAssumeUnderTest]Articulo target) {
            IProducto result = target.Producto;
            return result;
            // TODO: agregar aserciones a método ArticuloTest.ProductoGetTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para get_Recargo()</summary>
        [PexMethod]
        public double RecargoGetTest([PexAssumeUnderTest]Articulo target) {
            double result = target.Recargo;
            return result;
            // TODO: agregar aserciones a método ArticuloTest.RecargoGetTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para get_Total()</summary>
        [PexMethod]
        public double TotalGetTest([PexAssumeUnderTest]Articulo target) {
            double result = target.Total;
            return result;
            // TODO: agregar aserciones a método ArticuloTest.TotalGetTest(Articulo)
        }

        /// <summary>Código auxiliar de prueba para set_Cantidad(Int32)</summary>
        [PexMethod]
        public void CantidadSetTest([PexAssumeUnderTest]Articulo target, int value) {
            target.Cantidad = value;
            // TODO: agregar aserciones a método ArticuloTest.CantidadSetTest(Articulo, Int32)
        }

        /// <summary>Código auxiliar de prueba para set_Descuento(Double)</summary>
        [PexMethod]
        public void DescuentoSetTest([PexAssumeUnderTest]Articulo target, double value) {
            target.Descuento = value;
            // TODO: agregar aserciones a método ArticuloTest.DescuentoSetTest(Articulo, Double)
        }

        /// <summary>Código auxiliar de prueba para set_Precio(Double)</summary>
        [PexMethod]
        public void PrecioSetTest([PexAssumeUnderTest]Articulo target, double value) {
            target.Precio = value;
            // TODO: agregar aserciones a método ArticuloTest.PrecioSetTest(Articulo, Double)
        }

        /// <summary>Código auxiliar de prueba para set_Recargo(Double)</summary>
        [PexMethod]
        public void RecargoSetTest([PexAssumeUnderTest]Articulo target, double value) {
            target.Recargo = value;
            // TODO: agregar aserciones a método ArticuloTest.RecargoSetTest(Articulo, Double)
        }
    }
}
