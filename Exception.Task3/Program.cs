using Exception.Task3.Model;

namespace Exception.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("Welcome to the program!");
            while (running)
            {
                Console.WriteLine("Enter your command (1. Square, 2. Rectangle, 0.Quit):");
                int command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter the side length of the square:");
                            if (!double.TryParse(Console.ReadLine(), out double side))
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                                break;
                            }
                            
                            Square square = new Square(side);
                            Console.WriteLine($"The area of the square is: {square.CalculateArea()}");
                        }
                        catch (ArgumentException ex)
                        {
                            running = false;
                            Console.WriteLine($"Invalid input: {ex.Message}");
                        }
                        catch (System.Exception ex) 
                        {
                            running = false;
                            Console.WriteLine($"Unexpected error: {ex.Message}");
                        }
                        break;
                        
                    case 2:
                        try
                        {
                            Console.WriteLine("Enter the length of the rectangle:");
                            double length = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter the width of the rectangle:");
                            double width = Convert.ToDouble(Console.ReadLine());
                            Rectangular rectangle = new Rectangular(length, width);
                            Console.WriteLine($"The area of the rectangle is: {rectangle.CalculateArea()}");
                        }
                        catch (ArgumentException ex)
                        {
                            running = false;
                            Console.WriteLine($"Invalid input: {ex.Message}");
                        }
                        catch (System.Exception ex)
                        {
                            running = false;
                            Console.WriteLine($"Unexpected error: {ex.Message}");
                        }
                        break;

                    case 0:
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                        
                    default:
                        Console.WriteLine("Invalid command. Please try again.");
                        break;
                }
            }
        }
    }
}
