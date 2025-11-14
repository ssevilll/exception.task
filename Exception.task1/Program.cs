using Exception.task1.Currencies;

namespace Exception.task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manat manat = new Manat(170);
            //Dollar dollar = manat;
            //Console.WriteLine($"{manat.Azn} AZN = {dollar.Usd} USD");

            //Euro euro = manat;
            //Console.WriteLine($"{manat.Azn} AZN = {euro.Eur} EUR");

            //Lira lira = manat;
            //Console.WriteLine($"{manat.Azn} AZN = {lira.Try} TRY");

            //Dollar dollar1 = new Dollar(200);
            //Manat manat1 = dollar1;
            //Console.WriteLine($"{dollar1.Usd} USD = {manat1.Azn} AZN");

            //Euro euro1 = new Euro(150);
            //Manat manat2 = euro1;
            //Console.WriteLine($"{euro1.Eur} EUR = {manat2.Azn} AZN");

            //Lira lira1 = new Lira(300);
            //Manat manat3 = lira1;
            //Console.WriteLine($"{lira1.Try} TRY = {manat3.Azn} AZN");


            double result1 = Exchange(Currecy.Usd, 170);
            Console.WriteLine($"170 AZN = {result1} USD");

            double result2 = Exchange(Currecy.Eur, 180);
            Console.WriteLine($"180 AZN = {result2} EUR");

            double result3 = Exchange(Currecy.Try, 90);
            Console.WriteLine($"90 AZN = {result3} TRY");





        }

        public static double Exchange(Enum currency, double azn)
        {
            double result = 0;
            switch ((Currecy)currency)
            {
                case Currecy.Usd:
                    result = azn / 1.7;
                    break;
                case Currecy.Eur:
                    result = azn / 1.8;
                    break;
                case Currecy.Try:
                    result = azn / 0.09;
                    break;
            }
            return result;
        }
    }

}
