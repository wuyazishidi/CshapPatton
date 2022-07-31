using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern {
    class Client {
        static void Main(string[] args) {
            Proxy p = new Proxy();
            p.Request();
            Console.ReadKey();
        }
    }
}
