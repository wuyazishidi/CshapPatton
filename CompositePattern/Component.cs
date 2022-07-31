using System;
using System.Collections;

namespace CompositePatternSave {
    abstract class Component {
        protected string name;

        public Component(string name) {
            this.name = name;
        }
        public abstract void Display(int depth);
    }

    class Composite : Component {
        private ArrayList children = new ArrayList();
        public Composite(string name) : base(name) { }
        public void Add(Component component) {
            children.Add(component);
        }

        public void Remove(Component component) {
            children.Remove(component);
        }
        public override void Display(int depth) {
            Console.WriteLine(new String('-', depth) + name);
            foreach (Component component in children) {
                component.Display(depth + 2);
            }
        }
    }

    class Leaf : Component {

        public Leaf(string name) : base(name) { }

        public override void Display(int depth) {
            Console.WriteLine(new String('-',depth)+name);
        }
    }
}
