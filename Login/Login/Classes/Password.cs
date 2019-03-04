using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{
    /// LAST EDITED BY: Troy 
    /// DATE: 2/21/2019
    /// DESCRIPTION: Class to Manage Passwords. It encrypts entered Passwords. 
    /// It checks entered Passwords against Passwords given to it from a db.
    /// It gives strength of password
    /// Inspired by https://stackoverflow.com/questions/4181198/how-to-hash-a-password specfically User csharptest.net 's response
    class Password
    {
        //HashedPassword is a string that has been converted from a byte array that has the salt and encrypted password.
        private string HashedPassword;

        //salt contains a byte array that is the salt used to hash the password.
        private byte[] salt;
        public Password()
        {}

        //This function takes an entered String and encrypts it by generating random salt, hashing with that salt, and then converting it to a string
        //returns encrypted password as a string
        public string encryptPassword(string enteredPassword)
        {
            makeSalt();

            byte[] hash = hashPassword(enteredPassword);

            HashedPassword = stringifySaltedHashedPassword(hash);

            return HashedPassword;
        }

        //This function takes an entered String and matches it against a password that has been encrypted using this method then returns boolean
        //Works by finding salt in dbPassword then hashing with that salt on the entered password
        //then returns the value of comparison
        public Boolean verifyPasswordMatch(string dbPassword, string enteredPassword)
        {
            findSalt(dbPassword);

            byte[] hash = hashPassword(enteredPassword);

            HashedPassword = stringifySaltedHashedPassword(hash);

            return HashedPassword == dbPassword ? true : false;
        }

        //This function fills the salt attribute with 16 sized byte array
        private void makeSalt()
        {
           new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
        }

        //This function fills the salt attribute with the salt for the given password
        private void findSalt(string dbPassword)
        {
            byte[] hashBytes = Convert.FromBase64String(dbPassword);

            salt = hashBytes.Take(16).ToArray();
        }

        //This function returns an encrypted password without salt
       private byte[] hashPassword(string enteredPassword)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000);

            return pbkdf2.GetBytes(20);
        }

        //This function returns a string that is salt concatenated with encrypted password as string
        private string stringifySaltedHashedPassword(byte[] hash)
        {
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }

        //This function returns password strength as int 
        //null password is -64 points and bare requirements are 0
        public int DeterminePasswordStrength(string enteredPassword)
        {
            int passwordStrength = -64;

            for (int i = 0; i < enteredPassword.Length; i++)
                passwordStrength += 5;

            Boolean hasLower = false;
            Boolean hasUpper = false;

            for (int i = 0; i < enteredPassword.Length; i++)
            {
                char current = enteredPassword[i];
                if (!hasLower && current == enteredPassword.ToLower()[i])
                    hasLower = true;

                if (!!hasUpper && current == enteredPassword.ToUpper()[i])
                    hasUpper = true;

                if (Char.IsNumber(current))
                    passwordStrength += 8;

                if (Char.IsSymbol(current) || Char.IsPunctuation(current))
                    passwordStrength += 8;
            }

            if (hasUpper)
                passwordStrength += 8;

            if (hasLower)
                passwordStrength += 8;
               
            return passwordStrength;
        }

    

    }
}
