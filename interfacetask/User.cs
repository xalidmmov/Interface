using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace interfacetask
{
    public class User: IAccount
    {
        User[] Users = new User[0];
        private int _id;
        public int ID { get; set; }
        public string FullName;
        public string Email;
        public string Password;

       


        public User(string fullName, string email, string password)
        {
            ++_id;
            ID = _id;
            FullName = fullName;
            Email = email;
            Password = password;

        }
        public void UserADD(User user)
        {
            Array.Resize(ref Users, +1);
            Users[Users.Length - 1] = user;
        }


        public void ShowFullInfo()
        {
            Console.WriteLine($"Id :{ID}  Fullname : {FullName}  Email :{Email}   Password:{Password}");

        }
        public bool PasswordChecker(string password)
        {
            password = password.Trim(); 

            if (password.Contains(" "))
            {
                Console.WriteLine("Şifrede sozler arasinda bosluq olmamalidir.");
                return false;
            }

            if (password.Length < 8)
            {
                Console.WriteLine("Şifre en az 8 simvoldan ibaret olmalidir.");
                return false;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            if (!hasUpper)
            {
                Console.WriteLine("Şifrede en az bir boyuk herf olmalidir.");
                return false;
            }
            if (!hasLower)
            {
                Console.WriteLine("Şifrede en az bir kicik herf olmalidir.");
                return false;
            }
            if (!hasDigit)
            {
                Console.WriteLine("Şifrde en az bir reqem olmalidir.");
                return false;
            }

            return true;
        }


    }


}
