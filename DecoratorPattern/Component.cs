using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern {
    abstract class Component {
        abstract public void Operation();
    }
    class ConcreteComponet : Component {
        public override void Operation() {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }

    abstract class Decorator : Component {
        protected Component comoponent;

        public void SetComponent(Component component) {
            this.comoponent = comoponent;
        }
        public override void Operation() {
            if (comoponent != null)
                comoponent.Operation();
        }
    }
    class ConcreteDecoratorA : Decorator {
        private string addenState;
        override public void Operation() {
            base.Operation();
            addenState = "new state";
            Console.WriteLine("ConcreteDecorator.Operation");
        }
    }

    class ConcreteDecoratorB : Decorator {
        public override void Operation() {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecorator.Operation()");
        }
        void AddedBehavior() {

        }

    }
}
