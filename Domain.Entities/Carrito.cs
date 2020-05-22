using Domain.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
	public enum TipoMedioDePago { Desconocido, Tarjeta, PayPal, Contrareembolso, Transferencia }
	public enum TipoEnvio { Normal, Urgente, Exento	}
	public class Carrito {
		public int IdCarrito { get; set; }

		public TipoMedioDePago MedioDePago { get; set; } = TipoMedioDePago.Tarjeta;
		public TipoEnvio Envio { get; set; } =  TipoEnvio.Normal;
		public bool Seguro { get; set; } = false;

		private readonly List<IArticulo> articulos = new List<IArticulo>();

		public List<IArticulo> Articulos { get => articulos.Select(item => item.Clone() as IArticulo).ToList(); }

		public IArticulo this[int index] {
			get {
				return articulos[index];
			}
		}

		public int NumeroLineas => articulos.Count;

		public void Add(IArticulo articulo) {
			articulos.Add(articulo);
		}

		public void Add(Producto producto, int cantidad = 1) {
			articulos.Add(new Articulo(producto, cantidad));
		}


		public int AddCantidad(int index, int cantidad) {
			Debug.Assert(0 <= index && index < articulos.Count);
			return articulos[index].AddCantidad(cantidad);
		}

		public int AddCantidad(Producto producto, int cantidad) {
			return articulos.First(item => item.Producto == producto)
					.AddCantidad(cantidad);
		}

		public int RemoveCantidad(int index, int cantidad) {
			return articulos[index].RemoveCantidad(cantidad);
		}

		public int RemoveCantidad(Producto producto, int cantidad) {
			return articulos.First(item => item.Producto == producto).RemoveCantidad(cantidad);
		}

		public void Remove(int index) {
			articulos.RemoveAt(index);
		}

		public void Clear() {
			articulos.Clear();
		}

		public double CalculaRecargo(double total, TipoMedioDePago medioDePago = TipoMedioDePago.Transferencia, TipoEnvio envio = TipoEnvio.Normal, bool seguro = false) {
			if (total <= 0) return 0;
			double rslt = 0;
			switch(medioDePago) {
				case TipoMedioDePago.Tarjeta:
				case TipoMedioDePago.PayPal:
					rslt += total * 0;
					break;
				case TipoMedioDePago.Contrareembolso:
					rslt += total * 0.1;
					break;
				case TipoMedioDePago.Transferencia:
					rslt -= total * 0.1;
					break;
				default:
					throw new InvalidOperationException();
			}
			switch(envio) {
				case TipoEnvio.Normal:
					rslt += total * 0.05;
					break;
				case TipoEnvio.Urgente:
					rslt += total * 0.1;
					break;
			}
			if(seguro) 
				rslt += total * 0.05;
			return rslt;
		}
		public double Total { get => ImporteSinDescuento - ImporteDescuento; }

		public double ImporteDescuento { get => articulos.Sum(item => item.ImporteDescuento); }

		public double ImporteSinDescuento { get => articulos.Sum(item => item.ImporteSinDescuento); }

	}	
}
