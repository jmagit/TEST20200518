using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExterna {
    class Program {
        static int Main(string[] args) {
            if (args.Length > 0 && args[0] == "ko")
                return 1;
            else
                return 0;

        }
    }
}
