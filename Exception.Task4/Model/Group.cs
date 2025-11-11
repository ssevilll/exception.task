namespace Exception.Task4.Model
{
    internal class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get { return StudentLimit; }
            set
            {
                if (_students.Length >= 5 && _students.Length <= 18)
                    value = StudentLimit;
                else
                    throw new System.Exception("Student limit must be between 5 and 18");
            }
        }
        private Student[] _students = new Student[0];
    }
}
