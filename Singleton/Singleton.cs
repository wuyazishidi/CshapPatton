using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern {
    class Singleton {
        private static Singleton instance;
        protected Singleton(){}
        public static Singleton Instance() {
            //Uses Lazy initialization
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

    }
}
