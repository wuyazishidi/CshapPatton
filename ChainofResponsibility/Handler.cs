using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility {
   abstract class Handler {
        protected Handler successor;

        public void SetSuccessor(Handler successor) {
            this.successor = successor;
        }
        abstract public void HandleRequest(int request);
    }
    class ConcreteHandler1 : Handler {
        public override void HandleRequest(int request) {
            if (request >= 0 && request < 10)
                Console.WriteLine("{0}handled request{1}",this,request);
            else
                if (successor != null)
                successor.HandleRequest(request);
        }
    }
    class ConcreteHandler2 : Handler {
        public override void HandleRequest(int request) {
            if (request >= 10)
                Console.WriteLine("{0}handled request{1}", this, request);
            else
                if (successor != null)
                successor.HandleRequest(request);
        }
    }

    class ConcreteHandler3 : Handler {
        public override void HandleRequest(int request) {
            if (request >=20&&request<=30)
                Console.WriteLine("{0}handled request{1}", this, request);
            else
                if (successor != null)
                successor.HandleRequest(request);
        }
    }
}
