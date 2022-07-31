using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern {
    class Client {
        static void Main(string[] args) {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();
            Console.ReadKey();
        }
    }
}
