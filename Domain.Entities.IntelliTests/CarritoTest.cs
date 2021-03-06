// <copyright file="CarritoTest.cs" company="HP Inc.">Copyright © HP Inc. 2020</copyright>
using System;
using System.Collections.Generic;
using Domain.Entities;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Entities.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para Carrito</summary>
    [PexClass(typeof(Carrito))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CarritoTest
    {
        /// <summary>Código auxiliar de prueba para AddCantidad(Int32, Int32)</summary>
        [PexMethod]
        public int AddCantidadTest(
            [PexAssumeUnderTest]Carrito target,
            int index,
            int cantidad
        )
        {
            PexAssume.IsTrue(index > 0);
            int result = target.AddCantidad(index, cantidad);
            PexAssert.IsTrue(cantidad > 0);
            return result;
            // TODO: agregar aserciones a método CarritoTest.AddCantidadTest(Carrito, Int32, Int32)
        }

        /// <summary>Código auxiliar de prueba para AddCantidad(Producto, Int32)</summary>
        [PexMethod]
        public int AddCantidadTest01(
            [PexAssumeUnderTest]Carrito target,
            Producto producto,
            int cantidad
        )
        {
            int result = target.AddCantidad(producto, cantidad);
            return result;
            // TODO: agregar aserciones a método CarritoTest.AddCantidadTest01(Carrito, Producto, Int32)
        }

        /// <summary>Código auxiliar de prueba para Add(IArticulo)</summary>
        [PexMethod]
        public void AddTest([PexAssumeUnderTest]Carrito target, IArticulo articulo)
        {
            target.Add(articulo);
            // TODO: agregar aserciones a método CarritoTest.AddTest(Carrito, IArticulo)
        }

        /// <summary>Código auxiliar de prueba para Add(Producto, Int32)</summary>
        [PexMethod]
        public void AddTest01(
            [PexAssumeUnderTest]Carrito target,
            Producto producto,
            int cantidad
        )
        {
            target.Add(producto, cantidad);
            // TODO: agregar aserciones a método CarritoTest.AddTest01(Carrito, Producto, Int32)
        }

        /// <summary>Código auxiliar de prueba para get_Articulos()</summary>
        [PexMethod]
        public List<IArticulo> ArticulosGetTest([PexAssumeUnderTest]Carrito target)
        {
            List<IArticulo> result = target.Articulos;
            return result;
            // TODO: agregar aserciones a método CarritoTest.ArticulosGetTest(Carrito)
        }

        /// <summary>Código auxiliar de prueba para CalculaRecargo(Double, TipoMedioDePago, TipoEnvio, Boolean)</summary>
        [PexMethod]
        public double CalculaRecargoTest(
            [PexAssumeUnderTest]Carrito target,
            double total,
            TipoMedioDePago medioDePago,
            TipoEnvio envio,
            bool seguro
        )
        {
            double result = target.CalculaRecargo(total, medioDePago, envio, seguro);
            return result;
            // TODO: agregar aserciones a método CarritoTest.CalculaRecargoTest(Carrito, Double, TipoMedioDePago, TipoEnvio, Boolean)
        }

        /// <summary>Código auxiliar de prueba para Clear()</summary>
        [PexMethod]
        public void ClearTest([PexAssumeUnderTest]Carrito target)
        {
            target.Clear();
            // TODO: agregar aserciones a método CarritoTest.ClearTest(Carrito)
        }

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod]
        public Carrito ConstructorTest()
        {
            Carrito target = new Carrito();
            return target;
            // TODO: agregar aserciones a método CarritoTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para get_ImporteDescuento()</summary>
        [PexMethod]
        public double ImporteDescuentoGetTest([PexAssumeUnderTest]Carrito target)
        {
            double result = target.ImporteDescuento;
            return result;
            // TODO: agregar aserciones a método CarritoTest.ImporteDescuentoGetTest(Carrito)
        }

        /// <summary>Código auxiliar de prueba para get_ImporteSinDescuento()</summary>
        [PexMethod]
        public double ImporteSinDescuentoGetTest([PexAssumeUnderTest]Carrito target)
        {
            double result = target.ImporteSinDescuento;
            return result;
            // TODO: agregar aserciones a método CarritoTest.ImporteSinDescuentoGetTest(Carrito)
        }

        /// <summary>Código auxiliar de prueba para get_Item(Int32)</summary>
        [PexMethod]
        public IArticulo ItemGetTest([PexAssumeUnderTest]Carrito target, int index)
        {
            IArticulo result = target[index];
            return result;
            // TODO: agregar aserciones a método CarritoTest.ItemGetTest(Carrito, Int32)
        }

        /// <summary>Código auxiliar de prueba para get_NumeroLineas()</summary>
        [PexMethod]
        public int NumeroLineasGetTest([PexAssumeUnderTest]Carrito target)
        {
            int result = target.NumeroLineas;
            return result;
            // TODO: agregar aserciones a método CarritoTest.NumeroLineasGetTest(Carrito)
        }

        /// <summary>Código auxiliar de prueba para RemoveCantidad(Int32, Int32)</summary>
        [PexMethod]
        public int RemoveCantidadTest(
            [PexAssumeUnderTest]Carrito target,
            int index,
            int cantidad
        )
        {
            int result = target.RemoveCantidad(index, cantidad);
            return result;
            // TODO: agregar aserciones a método CarritoTest.RemoveCantidadTest(Carrito, Int32, Int32)
        }

        /// <summary>Código auxiliar de prueba para RemoveCantidad(Producto, Int32)</summary>
        [PexMethod]
        public int RemoveCantidadTest01(
            [PexAssumeUnderTest]Carrito target,
            Producto producto,
            int cantidad
        )
        {
            int result = target.RemoveCantidad(producto, cantidad);
            return result;
            // TODO: agregar aserciones a método CarritoTest.RemoveCantidadTest01(Carrito, Producto, Int32)
        }

        /// <summary>Código auxiliar de prueba para Remove(Int32)</summary>
        [PexMethod]
        public void RemoveTest([PexAssumeUnderTest]Carrito target, int index)
        {
            target.Remove(index);
            // TODO: agregar aserciones a método CarritoTest.RemoveTest(Carrito, Int32)
        }

        /// <summary>Código auxiliar de prueba para get_Total()</summary>
        [PexMethod]
        public double TotalGetTest([PexAssumeUnderTest]Carrito target)
        {
            double result = target.Total;
            return result;
            // TODO: agregar aserciones a método CarritoTest.TotalGetTest(Carrito)
        }
    }
}
