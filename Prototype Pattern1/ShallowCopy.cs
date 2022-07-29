using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern_ShallowCopy {
    class ShallowCopy : ICloneable {

        public int[] v = { 1, 2, 3 };
        public object Clone() {
            return this.MemberwiseClone();
        }

        public void Display() {
            foreach (int i in v) {
                Console.Write(i+",");
                Console.WriteLine();
            }
        }
    }
}
