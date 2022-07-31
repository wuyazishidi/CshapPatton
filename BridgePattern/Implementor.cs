using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern {
    abstract class Implementor {
        abstract public void Operation();
    }

    class ConcreteImplementorA : Implementor {
        public override void Operation() {
            Console.WriteLine("ConcreteImplementorA Operation");
        }

    }
    class ConcreteImplementorB : Implementor {
        public override void Operation() {
            Console.WriteLine("ConcreteImplementorB Operation");
        }

    }
}
