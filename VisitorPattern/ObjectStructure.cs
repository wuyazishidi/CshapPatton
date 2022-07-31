using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern {
    class ObjectStructure {
        private ArrayList elements = new ArrayList();
        public void Attach(Element element) {
            elements.Add(element);
        }
        public void Accept(Visitor visitor) {
            foreach (Element element in elements) {
                element.Accept(visitor);
            }
        }
    }
}
