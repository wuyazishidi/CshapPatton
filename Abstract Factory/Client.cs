using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory {
    class Client {
        static void Main(string[] args) {
            AbstractFactory factory1 = new ConcreteFactory1();
            Environment e1 = new Environment(factory1);
            e1.Run();

            AbstractFactory factory2 = new ConcreteFactory2();
            Environment e2 = new Environment(factory2);
            e2.Run();
            Console.ReadKey();
        }
    }
}
