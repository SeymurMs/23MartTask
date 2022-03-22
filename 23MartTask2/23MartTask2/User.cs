using System;
using System.Collections.Generic;
using System.Text;

namespace _23MartTask2
{
    internal class User: IAccount
    {
        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
        private string _fullName;
        private string _email;
        private string _password;
        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (PasswordChecker()== true && value.Length > 7)
                {
                    _password = value;
                }
            }
        }
        public bool PasswordChecker()
        {

            bool chk1 = false;
            bool chk2= false;
            bool chk3= false ;
            if (!string.IsNullOrWhiteSpace(Password))
            {

            
            for (int i = 0; i < Password.Length; i++)
            {
                if (char.IsDigit(Password[i]))
                {
                    chk1= true;
                }
                else if (char.IsUpper(Password[i]))
                {
                    chk2=true;
                }
                else if (char.IsLower(Password[i]))
                {
                    chk3=true;
                }
                }

            }
            if (chk1 ==true && chk2 == true && chk3 == true)
            {
                return true;
            }
            else
                return false;
            
                
        }

        

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname - {this.FullName} E-mail - {this.Email} Password - {this.Password}"); ;
        }

        
    }
}
