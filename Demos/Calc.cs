using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    public class Calc {
        public double suma(double o1, double o2) {
            return o1 + o2;
        }
        public double multiplica(double o1, double o2) {
            return o1 * o2;
        }
        public double divide(double o1, double o2) {
            if (o2 == 0)
                throw new DivideByZeroException();
            return o1 / o2;
        }

        public double Area(double radio) => 2 * Math.PI * radio;
    }
}
