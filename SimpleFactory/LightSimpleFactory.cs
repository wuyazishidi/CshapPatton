namespace SimpleFactory {
    public class LightSimpleFactory {
        public Light Create(string LightType) {
            if (LightType == "Bulb")
                return new BulbLight();
            else if (LightType == "Tube")
                return new TubeLight();
            else return null;
        }

    }
}
