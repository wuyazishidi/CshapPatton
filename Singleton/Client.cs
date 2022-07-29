﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern {
    class Client {
        static void Main(string[] args) {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
                Console.WriteLine("The same instance");
            Console.ReadKey();
        }
    }
}
