using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample {
    class Client {
        static void Main(string[] args) {
            Employees e = new Employees();
            e.Attach(new Employee("Hank",25000.0,14)) ;
            e.Attach(new Employee("Elly",35000.0,16)) ;
            e.Attach(new Employee("Dick",45000.0,21)) ;
            IncomeVisitor v1 = new IncomeVisitor();
            IncomeVisitor v2 = new IncomeVisitor();
            e.Accept(v1);
            e.Accept(v2);
            Console.ReadKey();
        }
    }
}
