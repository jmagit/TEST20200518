using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    public interface ILoadTextFile {
        bool IsLoad { get; set; }
        string[] Lines { get; set; }
        int Size { get; }
    }

    public interface IProcessTextFile {
        string Calculate(ILoadTextFile file);
    }

    public class LoadTextFile : ILoadTextFile {
        public string[] Lines { get; set; }
        public bool IsLoad { get; set; } = false;
        public int Size => Lines.Length;

        public LoadTextFile() {
            Lines = new string[] { };
        }
        public LoadTextFile(string fileName) {
            this.Lines = System.IO.File.ReadAllLines(fileName);
            IsLoad = true;
        }
    }

}
