namespace BoilerControlSystem
{
    public abstract class Sensor
    {
        public string Name { get; protected set; }

        protected Sensor(string name)
        {
            Name = name;
        }

        public abstract void Measure();
    }
}