using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgApi.Utils
{
    public class Criptografia
    {
        public static void CriarPasswordHash(string password, out byte[] hash, out byte[] salt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                salt = hmac.Key;
                hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerificarPassowordHash(string password, byte[] hash, byte[] salt)
            {
                using (var hmac = new System.Security.Cryptography.HMACSHA512(salt))
                {
                    var ComputeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                    for (int i = 0; i < ComputeHash.Length; i++)
                    {
                        if (ComputeHash [i] != hash[i])
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
    }
}