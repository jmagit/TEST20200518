using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
	[Serializable]
	public class CompraException : Exception {
		public CompraException() {
		}

		public CompraException(string message) : base(message) {
		}

		public CompraException(string message, Exception innerException) : base(message, innerException) {
		}

		protected CompraException(SerializationInfo info, StreamingContext context) : base(info, context) {
		}
	}
}
