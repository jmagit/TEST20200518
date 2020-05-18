using System;

namespace Domain.Entities {
    public interface IProducto: ICloneable {
        Estado Estado { get; }
        int IdProducto { get; set; }
        bool IsDescatalogado { get; }
        string Nombre { get; set; }
        double Precio { get; set; }

        void Descatalogar();
        void Recatalogar(double precio);
        void SetConStock();
        void SetSinStock();
    }
}