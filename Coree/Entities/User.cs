using Coree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilss.Exeptions;

namespace Coree.Entities
{
    public class User : IAccount
    {
        private static int _id;
        public int Id { get; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User(string email, string password)
        {
            Id = ++_id;
            Email = email;
            Password = password;
        }

        public string PasswordChecker(string password)
        {
            if (password.Length >= 8)
            {
                bool IsUpper = false;
                bool IsLower = false;
                bool IsNumber = false;

                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                        IsUpper = true;
                    else if (char.IsLower(c))
                        IsLower = true;
                    if (char.IsNumber(c))
                        IsNumber = true;

                    if (IsUpper && IsLower && IsNumber)
                        return password;
                }
            }
            throw new IncorrectPasswordException("Given password is incorrect, please try it again");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n{this.Id}-\n{this.FullName}-\n{this.Email}");
        }
    }
}
