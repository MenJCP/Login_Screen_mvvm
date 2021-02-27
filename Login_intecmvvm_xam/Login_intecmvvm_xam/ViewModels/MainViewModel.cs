using System;
using System.Collections.Generic;
using System.Text;

namespace Login_intecmvvm_xam.ViewModels
{
   public class MainViewModel
    {
        public string emailtxt { get; } = "Email";
        public string emailEntry { get; set; }
        public string passwordtxt { get; } = "Password";
        public string passwordEntry { get; set; }
        public string logintxt { get; } = "Login";
        public string registertxt { get; } = "Register";
        public string nametxt { get; } = "Name";
        public string nameEntry { get; set; }
        public string password2txt { get; } = "Confirm Password";
        public string password2Entry { get; set; }
        
        public MainViewModel()
        {

        }

    }
}
