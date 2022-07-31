using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSave {
    /*安全式的合成模式的实现*/
    class Client {
        static void Main(string[] args) {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("CompositeX");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            Leaf I = new Leaf("Leaf D");
            root.Add(I);
            root.Remove(I);

            root.Display(1);


            Console.ReadKey();

        }
    }
}
