using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern {
    public class Sensor {
        public void Activate() {
            Console.WriteLine("Deactivating the sensor");
        }

        public void Trigger() {
            Console.WriteLine("The sensor has trigered");
        }
    }
}
