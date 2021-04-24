namespace CreationPatterns._4__Builder.Example_1.Components
{
    public class Engine
    {
        private int power;
        public int Power { get => power; set => power = value; }

        public Engine(int power)
        {
            this.Power = power;
        }
    }
}
