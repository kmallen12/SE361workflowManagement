using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{
    class Password
    {
        string HashedPassword { get; }
        byte[] hashBytes;
        Boolean match = true;
        public Password(string s)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(s, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            HashedPassword = Convert.ToBase64String(hashBytes); 
        }

        public Password(string dbPassword, string enteredPassword)
        { 

            hashBytes = Convert.FromBase64String(dbPassword);

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    match = false;

        }

        public Boolean verifyPassword()
        {
            return match ? true : false;
        }

    }
}
