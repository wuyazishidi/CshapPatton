using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory {
    abstract class AbstractFactory {
        abstract public AbstractProductA CreateProductA();
        abstract public AbstractProductB CreateProductB();
    }

    class ConcreteFactory1 : AbstractFactory {
        public override AbstractProductA CreateProductA() {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB() {
            return new ProductB1();
        }
    }

    class ConcreteFactory2 : AbstractFactory {
        public override AbstractProductA CreateProductA() {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB() {
            return new ProductB2();
        }
    }

    abstract class AbstractFactoryA { 
    
    }

    abstract class AbstractFactoryB{

    }
}
