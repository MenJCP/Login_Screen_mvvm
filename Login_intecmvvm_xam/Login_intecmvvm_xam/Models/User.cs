using System;
using System.Collections.Generic;
using System.Text;

namespace Login_intecmvvm_xam.Models
{
   public class User
    {
        public int Id { get; }
        public string Username { get; }
        public string Password { get; }


        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }


        public bool CheckInfo()
        {
            if (!string.IsNullOrEmpty(this.Username) || (!string.IsNullOrEmpty(this.Password)))
                return true;
            else
                return false;
        }
    }
}
