using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternExample {
    class BusinessObject {
        private DataObject dataObject;
        protected string group;

        public BusinessObject(string group) {
            this.group = group;
        }

        public DataObject DataObject {
            set {
                dataObject = value;
            }
            get {
                return dataObject;
            }
        }
        virtual public void Next() {
            dataObject.NextRecord();
        }
        virtual public void Prior() {
            dataObject.PriorRecord();
        }
        virtual public void New(string name) {
            dataObject.NewRecord(name);
        }
        virtual public void Delete(string name) {
            dataObject.DeleteRecord(name);
        }
        virtual public void Show() {
            dataObject.ShowRecord();
        }
        virtual public void ShowAll() {
            Console.WriteLine("Customer Group:{0}",group);
            dataObject.ShowAllRecords();
        }
    }

    class CustomersBusinessObject : BusinessObject {
        public CustomersBusinessObject(string group) : base(group) { }
        public override void ShowAll() {
            Console.WriteLine();
            Console.WriteLine("-------------");
            base.ShowAll();
            Console.WriteLine("----------------");
        }
    }
}
