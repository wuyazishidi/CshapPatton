using System;
using System.Collections;

namespace Builder_Pattern {
    class Product {
        ArrayList parts = new ArrayList();

        public void Add(string part) {
            parts.Add(part);
        }

        public void Show() {
            Console.WriteLine("Product Parts ------------");
            foreach (string part in parts) {
                Console.WriteLine(part);
            }
        }
    }
}
