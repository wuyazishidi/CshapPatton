using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample {
    abstract class Visitor {
        abstract public void Visit(Element element);
    }
    class IncomeVisitor : Visitor {
        public override void Visit(Element element) {
            Employee employee = (Employee)element;
            employee.Income *= 1.10;
            Console.WriteLine("{0}'s new income:{1:C}",employee.Name,employee.Income);
        }
    }
    class VacationVisitor : Visitor {
        public override void Visit(Element element) {
            Employee employee = (Employee)element;
            employee.VacationDays += 2;
            Console.WriteLine("{0}'s new vacation days:{1}",employee.Name,employee.VacationDays);
        }
    }
}
