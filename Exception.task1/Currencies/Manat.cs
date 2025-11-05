namespace Exception.task1.Currencies
{
    internal class Manat
    {
        public Manat (double azn)
        {
            Azn=azn;
        }

        public double Azn { get; set; }

        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.Usd * 1.7); 
        }

        public static implicit operator Manat(Euro euro)
        {
            return new Manat(euro.Eur * 1.85);
        }

        public static implicit operator Manat(Lira lira)
        {
            return new Manat(lira.Try * 0.087);
        }
    }
}
