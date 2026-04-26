using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace local_Tribs
{
    public class RSAHelper
    {
        private static readonly RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

        public static string Encrypt(string plainText)
        {
            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedData = rsa.Encrypt(data, false);
            return Convert.ToBase64String(encryptedData);
        }

        public static string Decrypt(string encryptedText)
        {
            byte[] data = Convert.FromBase64String(encryptedText);
            byte[] decryptedData = rsa.Decrypt(data, false);
            return Encoding.UTF8.GetString(decryptedData);
        }
    }
}
