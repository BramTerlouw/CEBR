using System;

namespace Model
{
    public class User
    {
        public string name { get; set; }
        public string password { get; set; }

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
