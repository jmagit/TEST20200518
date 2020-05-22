using System;

namespace Demos {
    public class Validaciones {
        public Validaciones() {
        }

        public bool IsNumeric(string v) {
            double rslt;
            
            return double.TryParse(v, out rslt);
        }
    }
}