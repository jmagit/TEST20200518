using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Entities;
// <auto-generated>
// Este archivo contiene pruebas generadas automáticamente.
// No modifique el archivo manualmente.
// 
// Si el contenido del archivo se queda obsoleto, puede eliminarlo.
// Por ejemplo, si ya no se compila.
// </auto-generated>
using System;

namespace Domain.Entities.Tests
{
    public partial class CarritoTest {

[TestMethod]
[PexGeneratedBy(typeof(CarritoTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void RemoveCantidadTest01ThrowsInvalidOperationException383()
{
    Carrito carrito;
    int i;
    carrito = new Carrito();
    carrito.IdCarrito = 0;
    carrito.MedioDePago = TipoMedioDePago.Desconocido;
    carrito.Envio = TipoEnvio.Normal;
    carrito.Seguro = false;
    i = this.RemoveCantidadTest01(carrito, (Producto)null, 0);
}
    }
}
