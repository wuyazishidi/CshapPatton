using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample {
    class Employees {
        private ArrayList employees = new ArrayList();
        public void Attach(Employee employee) {
            employees.Add(employee);
        }

        public void Detach(Employee employee) {
            employees.Remove(employee);
        }
        public void Accept(Visitor visitor) {
            foreach (Employee employee in employees) {
                employee.Accept(visitor);
            }
        }
    }
}
