using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory {
    class Environment {
        private AbstractProductA AbstractProductA;
        private AbstractProductB AbstractProductB;

        public Environment(AbstractFactory factory){
            AbstractProductB = factory.CreateProductB();
            AbstractProductA = factory.CreateProductA();
        }

        public void Run() {
            AbstractProductB.Interact(AbstractProductA);
        }
    }
}
