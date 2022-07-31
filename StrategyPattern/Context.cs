using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern {
    class Context {
        Strategy strategy;
        public Context(Strategy strategy) {
            this.strategy = strategy;
        }
        public void ContexInterface() {
            strategy.AlgorithmInterface();
        }
    }
}
