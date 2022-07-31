using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern {
    class Client {
        static void Main(string[] args) {
            CustomerDataObject c = new CustomerDataObject();
            c.Run();
            Console.ReadKey();
        }
    }
}
