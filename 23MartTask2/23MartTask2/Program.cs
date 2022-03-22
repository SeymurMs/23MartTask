using System;

namespace _23MartTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "asjdaskdas@gmail.com";
            string password = "seymur123";

            User user = new User(email,password)
            {
                
            };
            user.ShowInfo();
        }
    }
}
