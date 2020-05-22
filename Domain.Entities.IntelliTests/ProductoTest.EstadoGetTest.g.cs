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
    public partial class ProductoTest {

[TestMethod]
[PexGeneratedBy(typeof(ProductoTest))]
public void EstadoGetTest535()
{
    Producto producto;
    Estado i;
    producto = new Producto(0, (string)null, 0, Estado.ConStock);
    i = this.EstadoGetTest(producto);
    Assert.IsNotNull((object)producto);
    Assert.AreEqual<int>(0, producto.IdProducto);
    Assert.AreEqual<string>((string)null, producto.Nombre);
    Assert.AreEqual<double>(0, producto.Precio);
    Assert.AreEqual<Estado>(Estado.ConStock, producto.Estado);
    Assert.AreEqual<bool>(false, producto.IsDescatalogado);
}
    }
}
