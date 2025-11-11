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
        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
            {
                return true;
            }
            return false;
        }
        public void AddStudent(Student student)
        {
            if (_students.Length < StudentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                throw new System.Exception("Student limit exceeded");
            }
        }
        public void GetStudents(int id)
        {
            int count = 0;
            foreach (var student in _students)
            {
                if (student.Id == id)
                {
                    count++;
                    student.StudentInfo();
                    return;
                }
            }
            if (count == 0)
            {
                throw new System.Exception("Student not found");
            }
        }

        
    }
}

