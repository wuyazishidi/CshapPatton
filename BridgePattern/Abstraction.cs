using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern {
    class Abstraction {
        protected Implementor implementor;

        public Implementor Implementor {
            set {
                implementor = value;
            }
        }

        virtual public void Operation() {
            implementor.Operation();
        }
    }

    class RefinedAbstraction : Abstraction {
        public override void Operation() {
            implementor.Operation();
        }
    }
}
