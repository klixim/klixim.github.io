using System;

namespace PracticeTask8
{
    [Serializable]
    public class User
    {
        public string Login { get; set; }
        public DateTime RegistrationDate { get; set; }

        public User()
        {
            RegistrationDate = DateTime.Now;
        }

        public User(string login)
        {
            Login = login;
            RegistrationDate = DateTime.Now;
        }
    }
}