using Exception.task1.Currencies;

namespace Exception.task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manat manat = new Manat(170);
            Dollar dollar = manat;
            Console.WriteLine( $"{manat.Azn} AZN = {dollar.Usd} USD");

            Euro euro = manat;
            Console.WriteLine($"{manat.Azn} AZN = {euro.Eur} EUR");

            Lira lira = manat;
            Console.WriteLine($"{manat.Azn} AZN = {lira.Try} TRY");

            Dollar dollar1 = new Dollar(200);
            Manat manat1 = dollar1;
            Console.WriteLine($"{dollar1.Usd} USD = {manat1.Azn} AZN");

            Euro euro1 = new Euro(150);
            Manat manat2 = euro1;
            Console.WriteLine($"{euro1.Eur} EUR = {manat2.Azn} AZN");

            Lira lira1 = new Lira(300);
            Manat manat3 = lira1;
            Console.WriteLine($"{lira1.Try} TRY = {manat3.Azn} AZN");




        }
    }
}
