using System;
using System.Collections;

namespace FlyweightPattern {
    class FlyweightFactory {
        private Hashtable flyweights = new Hashtable();
        public FlyweightFactory() {
            flyweights.Add("X",new ConcreteFlyweight());
            flyweights.Add("Y",new ConcreteFlyweight());
            flyweights.Add("Z",new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key) {
            return (Flyweight)(flyweights[key]);
        }
    }

    abstract class Flyweight {
        abstract public void Operation(int extrinsicstate);
    }

    class ConcreteFlyweight : Flyweight {
        private string intrinsicstete = "A";
        public override void Operation(int extrinsicstate) {
            Console.WriteLine("ConcreteFlyweight:intrinsicstate{0},extrinsicstate{1}",intrinsicstete,extrinsicstate);
        }
    }

}
