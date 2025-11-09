using Exception.Task4.Interfaces;

namespace Exception.Task4.Model
{
    internal class User : IAccount
    {
        private static int _id=0;
        public int Id 
        { 
            get { return _id; } 
            set { _id = value; }
        }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, FullName: {FullName}, Email: {Email}");
        }
        public User(string email, string password)
        {
            _id++;
            Id = _id;
            Email = email;
            if (PasswordChecker(password))
            {
                Password = password;
            }
            else
            {
                throw new System.Exception("Password is not valid");
            }
        }
    }
}
