using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern {
    abstract class Prototype {
        private string id;
        public Prototype(string id) {
            this.id = id;
        }

        public string Id {
            get { return id; }
        }

        abstract public Prototype Clone();
    }

    class ConcretePrototype1 : Prototype {
        public ConcretePrototype1(string id) : base(id) { }

        public override Prototype Clone() {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class ConcretePrototype2 : Prototype {

        public ConcretePrototype2(string id) : base(id) { }
        public override Prototype Clone() {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
