
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern {
   abstract class Strategy {
        abstract public void AlgorithmInterface();
    }
    class ConcreteStrategyA : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
    class ConcreteStrategyB : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }

    class ConcreteStrategyC : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }

}
