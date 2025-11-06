using Exception.Task2.Model;

namespace Exception.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius c = new Celsius(25);
            Kelvin k = c; 
            Console.WriteLine($"{c.Degree} C is {k}");  
        }
    }
}
