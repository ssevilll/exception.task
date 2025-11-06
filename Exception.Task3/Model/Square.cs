namespace Exception.Task3.Model
{
    internal class Square : Figure
    {
        private double _side;
        public double Side 
        { 
            get { return _side; }
            set { if (value <= 0)
                {
                    throw new ArgumentException("Side length must be greater than zero.");
                }
                _side = value;
            }
        }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Side * Side;
        }

    }
}
