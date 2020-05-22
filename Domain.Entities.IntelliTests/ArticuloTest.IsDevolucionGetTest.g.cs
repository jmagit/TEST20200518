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
    public partial class ArticuloTest {

[TestMethod]
[PexGeneratedBy(typeof(ArticuloTest))]
public void IsDevolucionGetTest695()
{
    Producto producto;
    Articulo articulo;
    bool b;
    producto = new Producto(0, (string)null, 0, Estado.ConStock);
    articulo = new Articulo((IProducto)producto, 1, 0);
    b = this.IsDevolucionGetTest(articulo);
    Assert.IsNotNull((object)articulo);
    Assert.AreEqual<int>(1, articulo.Cantidad);
    Assert.AreEqual<double>(0, articulo.Precio);
    Assert.AreEqual<double>(0, articulo.Descuento);
    Assert.AreEqual<double>(0, articulo.Recargo);
    Assert.AreEqual<bool>(false, articulo.IsDevolucion);
    Assert.AreEqual<bool>(false, articulo.IsRegalo);
    Assert.AreEqual<double>(0, articulo.ImporteSinDescuento);
}
    }
}
