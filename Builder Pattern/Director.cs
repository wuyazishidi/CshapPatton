namespace Builder_Pattern {
    class Director {
        public void Construct(Builder builder) {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
