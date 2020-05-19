using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Articulo : IArticulo {
        private readonly IProducto producto;
        private int cantidad;
        private double precio;
        private double delta;

        public Articulo(IProducto producto) : this(producto, 1) { }
        public Articulo(IProducto producto, int cantidad) : this(producto, cantidad, 0) { }
        public Articulo(IProducto producto, int cantidad, double descuento) {
            this.producto = producto ?? throw new CompraException("El producto es obligatorio");
            this.precio = producto.Precio;
            this.Cantidad = cantidad;
            this.delta = descuento;
        }


        public IProducto Producto { get => (IProducto)producto.Clone(); }

        public int Cantidad {
            get => cantidad;
            set {
                if (value < 1) throw new CompraException("no acepta menos de 1");
                cantidad = value;
            }
        }

        public double Precio {
            get => precio;
            set {
                precio = value;
            }
        }
        protected bool IsProcentaje(double delta) {
            return 0 < delta && delta < 100;
        }


        public double Descuento {
            get => delta > 0 ? delta : 0;
            set {
                delta = value;
            }
        }

        public double Recargo {
            get => delta < 0 ? -delta : 0;
            set {
                delta = -value;
            }
        }

        public bool IsDevolucion {
            get => delta == 2;
        }
        public void SetDevolucion() {
            delta = 2;
        }


        public bool IsRegalo {
            get => delta == 1;
        }
        public void SetRegalo() {
            delta = 1;
        }

        public double ImporteSinDescuento {
            get => precio * cantidad;
        }

        public double ImporteDescuento {
            get => ImporteSinDescuento * delta;
        }

        public double Total {
            get => ImporteSinDescuento - ImporteDescuento;
        }


        public int AddCantidad(int cantidad) {
            this.cantidad += cantidad;
            return this.cantidad;
        }

        public int RemoveCantidad(int cantidad) {
            this.cantidad -= cantidad;
            return this.cantidad;
        }

        public override string ToString() {
            return "Articulo [producto=" + producto.Nombre + ", cantidad=" + cantidad + ", total=" + Total + "]";
        }

        public object Clone() {
            return new Articulo((IProducto)Producto.Clone(), Cantidad, Descuento);
        }
    }
}
