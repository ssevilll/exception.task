namespace Exception.Task2.Model
{
    internal class Kelvin
    {
        public double Degree { get; set; }

        public Kelvin(double degree)
        {
            Degree = degree;
        }

        public override string ToString()
        {
            return $"{Degree} K";
        }
    }
}
