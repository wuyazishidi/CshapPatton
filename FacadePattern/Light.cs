using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern {
    public class Light {
        public void TurnOff() {
            Console.WriteLine("Turning off the light");
        }

        public void TurnOn() {
            Console.WriteLine("Turning on the light ");
        }

        public void ChangeBulb() {
            Console.WriteLine("changing the ligth-bulb");
        }
    }
}

