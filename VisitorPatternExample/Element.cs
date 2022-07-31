using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample {
    abstract class Element {
        abstract public void Accept(Visitor visitor);
    }
    class Employee : Element {
        string name;
        double income;
        int vacationDays;
        public Employee(string name, double income, int vacationDays) {
            this.name = name;
            this.income = income;
            this.vacationDays = vacationDays;
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public double Income {
            get { return income; }
            set { income = value; }
        }
        public int VacationDays {
            get { return vacationDays; }
            set { vacationDays = value; }
        }
        public override void Accept(Visitor visitor) {
            visitor.Visit(this);
        }
    }
}
