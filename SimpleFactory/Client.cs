using System;

namespace SimpleFactory {
    class Client {
        static void Main(string[] args) {

            LightSimpleFactory lsf = new LightSimpleFactory();

            Light l = lsf.Create("Bulb");
            l.TurnOn();
            l.TurnOff();

            Console.WriteLine("---------------");
            l = lsf.Create("Tube");
            l.TurnOn();
            l.TurnOff();
            Console.ReadKey();
        }
    }
}
