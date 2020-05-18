using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {

    public enum Estado {
        ConStock, SinStock, Descatalogado
    }
    public class Producto : IProducto {

        private int idProducto;
        private String nombre;
        private double precio;
        private Estado estado;

        public Producto(int idProducto, String nombre, double precio, Estado estado = Estado.ConStock) {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.estado = estado;
        }

        public int IdProducto {
            get => idProducto;
            set {
                idProducto = value;
            }
        }

        public string Nombre {
            get => nombre;
            set {
                nombre = value;
            }
        }

        public double Precio {
            get => precio;
            set {
                precio = value;
            }
        }

        public Estado Estado { get => estado; }

        public void SetConStock() {
            estado = Estado.ConStock;
        }

        public void SetSinStock() {
            estado = Estado.SinStock;
        }

        public bool IsDescatalogado { get => estado == Estado.Descatalogado; }

        public void Descatalogar() {
            if (IsDescatalogado)
                throw new CompraException("El producto ya está descatalogado");
            estado = Estado.Descatalogado;
            precio = 0;
        }

        public void Recatalogar(double precio) {
            if (!IsDescatalogado)
                throw new CompraException("El producto no está descatalogado");
            estado = Estado.ConStock;
            this.precio = precio;
        }

        public override bool Equals(object obj) {
            return obj is Producto producto &&
                   idProducto == producto.idProducto;
        }

        public override int GetHashCode() {
            return 727929248 + idProducto.GetHashCode();
        }

        public override string ToString() {
            return "Producto [idProducto=" + idProducto + ", nombre=" + nombre + "]";
        }

        public object Clone() {
            return MemberwiseClone();
        }
    }

}
