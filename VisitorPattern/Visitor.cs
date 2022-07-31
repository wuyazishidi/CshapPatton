using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern {
    abstract class Visitor {
        abstract public void VisitConcreteElementA(ConcreteElementA concreteElementA);
        abstract public void VisitConcreteElementB(ConcteteElementB concteteElementB);

    }
    class ConcreteVisitor1 : Visitor {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA) {
            Console.WriteLine("{0}visited by{1}",concreteElementA,this);
        }

        public override void VisitConcreteElementB(ConcteteElementB concteteElementB) {
            Console.WriteLine("{0}visited by {1}",concteteElementB,this);
        }
    }
    class ConcreteVisitor2 : Visitor {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA) {
            Console.WriteLine("{0}visited by{1}", concreteElementA, this);
        }

        public override void VisitConcreteElementB(ConcteteElementB concteteElementB) {
            Console.WriteLine("{0}visited by {1}", concteteElementB, this);
        }
    }
}
