namespace Exception.task1.Currencies
{
    internal class Euro
    {
        public double Eur { get; set; }

        public Euro(double eur)
        {
            Eur = eur;
        }

        public static implicit operator Euro(Manat manat)
        {
            return new Euro(manat.Azn / 1.85);
        }
    }
}
