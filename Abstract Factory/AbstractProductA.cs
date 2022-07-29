using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory {
    abstract class AbstractProductA {
    }
    abstract class AbstractProductB {
        abstract public void Interact(AbstractProductA a);
    }

    class ProductA1 : AbstractProductA { 
    
    }
    class ProductA2 : AbstractProductA {

    }

    class ProductB1 : AbstractProductB {
        public override void Interact(AbstractProductA a) {
            Console.WriteLine(this+"interacts with "+a);
        }
    }

    class ProductB2 : AbstractProductB {
        public override void Interact(AbstractProductA a) {
            Console.WriteLine(this+"interacts with"+a);
        }
    }
}
