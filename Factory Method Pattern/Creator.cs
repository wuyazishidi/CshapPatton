namespace Factory_Method_Pattern {
    public abstract class Creator {
        public abstract Light factory();
    }

    public class BulbCreator : Creator {
        public override Light factory() {
            return new BulbLight();
        }
    }

    public class TubeCreator : Creator {
        public override Light factory() {
            return new TubeLight();
        }
    }
}
