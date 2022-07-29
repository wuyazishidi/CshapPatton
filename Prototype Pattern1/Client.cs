using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern_ShallowCopy {
    class Program {
        static void Main(string[] args) {
            ShallowCopy sc1 = new ShallowCopy();
            ShallowCopy sc2 = (ShallowCopy)sc1.Clone();
            sc1.v[0] = 9;
            sc1.Display();
            sc2.Display();

            Console.ReadKey();
        }
    }
}
