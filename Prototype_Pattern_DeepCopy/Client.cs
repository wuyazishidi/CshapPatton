using System;

namespace Prototype_Pattern_DeepCopy {
    class Client {
        static void Main(string[] args) {
            DeepCopy dc1 = new DeepCopy();
            DeepCopy dc2 = (DeepCopy)dc1.Clone();

            dc1.v[0] = 9;
            dc1.Display();
            dc2.Display();

            Console.ReadKey();
        }
    }
}
