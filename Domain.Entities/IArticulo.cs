using System;

namespace Domain.Entities {
    public interface IArticulo: ICloneable {
        int Cantidad { get; set; }
        double Descuento { get; set; }
        double ImporteDescuento { get; }
        double ImporteSinDescuento { get; }
        bool IsDevolucion { get; }
        bool IsRegalo { get; }
        double Precio { get; set; }
        IProducto Producto { get; }
        double Recargo { get; set; }
        double Total { get; }

        int AddCantidad(int cantidad);
        int RemoveCantidad(int cantidad);
        void SetDevolucion();
        void SetRegalo();
    }
}