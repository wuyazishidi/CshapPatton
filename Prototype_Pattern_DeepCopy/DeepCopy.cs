using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern_DeepCopy {
    class DeepCopy : ICloneable {
        public int[] v = { 1,2,3};

        public DeepCopy() { 
        
        }

        private DeepCopy(int[] v) {
            this.v = (int[])v.Clone();
        }
        public object Clone() {
            return new DeepCopy(this.v);
        }

        public void Display() {
            foreach (int i in v) {
                Console.Write(i+",");
                Console.WriteLine();
            }
        }
    }
}
