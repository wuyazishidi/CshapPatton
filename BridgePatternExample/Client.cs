using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternExample {
    class Client {
        static void Main(string[] args) {
            CustomersBusinessObject customers = new CustomersBusinessObject("Chicgo");
            customers.DataObject = new CustomersDataObject();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.New("Henry Velasquez");
            customers.ShowAll();
            Console.ReadKey();

        }
    }
}
