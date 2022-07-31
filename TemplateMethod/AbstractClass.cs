using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    abstract class AbstractClass {
        abstract public void PrimitiveOperation1();
        abstract public void PrimitiveOperation2();
        public void TemplateMethod() {
            Console.WriteLine("In AbstractClass.TemplateMethod()");
            PrimitiveOperation1();
            PrimitiveOperation2();
        }
    }
    class ConcreteClass : AbstractClass {
        public override void PrimitiveOperation1() {
            Console.WriteLine("Called ConcreteClass.PrimitiveOperation1()");
        }

        public override void PrimitiveOperation2() {
            Console.WriteLine("Called ConcreteClass.PrimitiveOperation2()");
        }
    }
}
