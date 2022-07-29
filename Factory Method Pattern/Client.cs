using System;

namespace Factory_Method_Pattern {
    class Client {
        static void Main(string[] args) {
            Creator c1 = new BulbCreator();
            Creator c2 = new TubeCreator();

            Light l1 = c1.factory();
            Light l2 = c2.factory();

            l1.TurnOn();
            l1.TurnOff();
            Console.WriteLine("----------------------");
            l2.TurnOn();
            l2.TurnOff();
            Console.ReadKey();
        }
    }
}
