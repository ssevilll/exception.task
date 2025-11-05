namespace Exception.task1.Currencies
{
    internal class Dollar
    {
        public double Usd { get; set; }

        public Dollar(double usd)
        {
            Usd = usd;
        }

        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }
    }
}
