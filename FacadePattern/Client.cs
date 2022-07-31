using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern {
    class Client {
        private static Camera camera1, camera2;
        private static Light light1, light2, light3;
        private static Sensor sensor;
        private static Alarm alarm;
        static Client() {
            camera1 = new Camera();
            camera2 = new Camera();
            light1 = new Light();
            light2 = new Light();
            light3 = new Light();
            sensor = new Sensor();
            alarm = new Alarm();
        }
        static void Main(string[] args) {
            camera1.TurnOn();
            camera2.TurnOn();
            light1.TurnOn();
            light2.TurnOn();
            light3.TurnOn();
            sensor.Activate();
            alarm.Activate();
            Console.ReadKey();
        }
    }
}
