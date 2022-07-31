using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern {
    interface ITarget {
        void Request();
    }
    class Adaptee {
        public void SpecificRequest() {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
    class Adapter : Adaptee, ITarget {
        public void Request() {
            this.SpecificRequest();
        }
    }
}
