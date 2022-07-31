using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    class Client {
        static void Main(string[] args) {
            ConcreteClass c = new ConcreteClass();
            c.TemplateMethod();
            Console.ReadKey();
        }
    }
}
