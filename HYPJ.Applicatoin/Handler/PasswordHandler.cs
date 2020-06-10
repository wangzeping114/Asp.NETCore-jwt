using HYPJ.Utilities.Helper;
using System;
using System.Security.Cryptography;

namespace HYPJ.Applicatoin.Handler
{
    public class PasswordHandler : IPasswordHandler
    {
        public string GenerateAppUserPwdHash(string salt, string pwd)
            => MD5Helper.MD5Hash(salt + MD5Helper.MD5Hash(pwd.Trim().ToUpper()));

        public (string salt, string pwdhash) GenerateEncryptPassword(string password)
        {
            var salt = GetSalt();
            var pwdhash = GenerateAppUserPwdHash(salt, password);
            return (salt, pwdhash);
        }

        public bool VerifyHashedPassword(string hashedPassword, string providedSalt, string providedPassword)
        {
            var generatePwd = GenerateAppUserPwdHash(providedSalt, providedPassword);

            return hashedPassword.Equals(generatePwd)
                ? true
                : false;
        }

        private static string GetSalt()
        {
            byte[] bytes = new byte[128 / 8];
            using (var keyGenerator = RandomNumberGenerator.Create())
            {
                keyGenerator.GetBytes(bytes);
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

    }
}
