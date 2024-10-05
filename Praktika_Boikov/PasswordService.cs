using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_Boikov
{
    public class PasswordService
    {
        private Random random = new Random();

        public string GeneratePassword(int lenght = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefgijklmnopqrstuvwxyz0123456789";
            StringBuilder password = new StringBuilder(lenght);
            for (int i = 0; i < lenght; i++)
            {
                password.Append(chars[random.Next(chars.Length)]);
            }
            return password.ToString();
        }

        public void EditPassword(User user, string newPassword)
        {
            user.Password = newPassword;
        }
    }
}
