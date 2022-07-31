using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern {
    abstract class Subject {
        abstract public void Request();
    }

    class RealSubject : Subject {
        public override void Request() {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }

    class Proxy : Subject {
        RealSubject realSubject;
        public override void Request() {
            if (realSubject == null)
                realSubject = new RealSubject();
            PreRequest();
            realSubject.Request();
            PostRequest();
        }

        public void PreRequest() {
            Console.WriteLine("PreRequest");
        }
        public void PostRequest() {
            Console.WriteLine("PostRequest");
        }
    }
}
