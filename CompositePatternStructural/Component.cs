using System;
using System.Collections;

namespace CompositePatternStructural {
    abstract class Component {
        protected string name;
        public Component(string name) {
            this.name = name;
        }

        abstract public void Add(Component c);
        abstract public void Remove(Component c);
        abstract public void Display(int depth);

    }

    class Composite : Component {
        private ArrayList children = new ArrayList();
        public Composite(string name) : base(name) { }

        public override void Add(Component c) {
            children.Add(c);
        }

        public override void Display(int depth) {
            Console.WriteLine(new string('-',depth)+name);
            foreach (Component component in children) {
                component.Display(depth+2);
            }
        }

        public override void Remove(Component c) {
            children.Remove(c);
        }
    }

    class Leaf : Component {
        public Leaf(string name) : base(name) { }

        public override void Add(Component c) {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Display(int depth) {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void Remove(Component c) {
            Console.WriteLine("Connot remove from a leaf");
        }
    }
}
