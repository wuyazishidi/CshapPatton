using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern {
    class Camera {
        public void TurnOn() {
            Console.WriteLine("Turning on the camera");
        }

        public void TurnOff() {
            Console.WriteLine("Turning off the camera");
        }

        public void Rotate(int degress) {
            Console.WriteLine("Rotating the camera by{0}degrees", degress);
        }
    }
}
