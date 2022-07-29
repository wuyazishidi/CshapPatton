namespace Builder_Pattern {
    abstract class Builder {
        abstract public void BuildPartA();
        abstract public void BuildPartB();
        abstract public Product GetResult();
    }

    class ConcreteBuilder1 : Builder {
        private Product product;
        public override void BuildPartA() {
            product = new Product();
            product.Add("PartA");
        }

        public override void BuildPartB() {
            product.Add("PartB");
        }

        public override Product GetResult() {
            return product;
        }
    }

    class ConcreteBuilder2 : Builder {
        private Product product;
        public override void BuildPartA() {
            product = new Product();
            product.Add("PartX");
        }

        public override void BuildPartB() {
            product.Add("PartB");
        }

        public override Product GetResult() {
            return product;
        }
    }
}
