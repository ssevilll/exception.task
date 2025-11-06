namespace Exception.Task2.Model
{
    internal class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273);
        }

        public override string ToString()
        {
            return $"{Degree} °C";
        }
    }
}
