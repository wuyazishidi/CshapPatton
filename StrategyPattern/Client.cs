using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern {
    class Client {
        static void Main(string[] args) {
            Context c = new Context(new ConcreteStrategyA());
            c.ContexInterface();

            Context d = new Context(new ConcreteStrategyB());
            d.ContexInterface();

            Context e = new Context(new ConcreteStrategyC());
            e.ContexInterface();

            Console.ReadKey();
        }
    }
}
