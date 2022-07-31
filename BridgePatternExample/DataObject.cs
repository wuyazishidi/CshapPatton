using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternExample {
    abstract class DataObject {
        abstract public void NextRecord();
        abstract public void PriorRecord();
        abstract public void NewRecord(string name);
        abstract public void DeleteRecord(string name);
        abstract public void ShowRecord();
        abstract public void ShowAllRecords();
    }

    class CustomersDataObject : DataObject {
        private ArrayList customers = new ArrayList();
        private int current = 0;

        public CustomersDataObject() {
            customers.Add("Jim Jones");
            customers.Add("Samual Jackson");
            customers.Add("Allen Good");
            customers.Add("Ann Stills");
            customers.Add("Lisa Giolani");
        }
        public override void DeleteRecord(string name) {
        }

        public override void NewRecord(string name) {
            customers.Add(name);
        }

        public override void NextRecord() {
            if (current <= customers.Count - 1)
                current++;
        }

        public override void PriorRecord() {
            if (current > 0)
                current--;
        }

        public override void ShowAllRecords() {
            foreach (string name in customers) {
                Console.WriteLine(" "+name);
            }
        }

        public override void ShowRecord() {
            Console.WriteLine(customers[current]);
        }
    }
}
