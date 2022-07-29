using System;

namespace SimpleFactory {
    public abstract class Light {
        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    public class BulbLight : Light {
        public override void TurnOff() {
            Console.WriteLine("Bulb Light is Turned off");
        }

        public override void TurnOn() {
            Console.WriteLine("Bulb Light is Turned on");
        }

    }
    public class TubeLight : Light {
        public override void TurnOff() {
            Console.WriteLine("Tube Light is Turned off");
        }

        public override void TurnOn() {
            Console.WriteLine("Tube Light is Turned on");
        }
    }
}

