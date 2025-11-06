namespace Exception.Task3.Model
{
    internal class Rectangular : Figure
    {
        private double _length;
        private double _width;

        public double Length 
        { 
            get { return _length; }
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Length must be greater than zero.");
                }
                _length = value; 
            }
        }

        public double Width 
        { 
            get { return _width; }
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be greater than zero.");
                }
                _width = value; 
            }
        }

        public Rectangular(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
