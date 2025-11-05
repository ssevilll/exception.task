namespace Exception.task1.Currencies
{
    internal class Lira
    {
        public double Try { get; set; }

        public Lira(double tr)
        {
            Try = tr;
        }

        public static implicit operator Lira(Manat manat)
        {
            return new Lira(manat.Azn / 0.087);
        }
    }
}
