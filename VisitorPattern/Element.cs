using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern {
    abstract class Element {
        abstract public void Accept(Visitor visitor);
    }

    class ConcreteElementA : Element {
        public override void Accept(Visitor visitor) {
            visitor.VisitConcreteElementA(this);
        }
        public void OperationA() {

        }
    }
    class ConcteteElementB : Element {
        public override void Accept(Visitor visitor) {
            visitor.VisitConcreteElementB(this);
        }
        public void OperationB() {

        }
    }
}
