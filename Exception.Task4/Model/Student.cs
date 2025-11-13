namespace Exception.Task4.Model
{
    internal class Student
    {
        private static int _id = 0;
        public int Id { get; }
        public string FullName { get; set; }
        public decimal Point { get; set; }
        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}, FullName: {FullName}, Point: {Point}");
        }
        public Student(string fullname, decimal point)
        {
            _id++;
            Id = _id;
            FullName = fullname;
            Point = point;
        }
    }
}
