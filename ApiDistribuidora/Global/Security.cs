using System.Security.Cryptography;
using System.Text;

namespace ApiDistribuidora.Global
{
    public class Security
    {
        const string encryptKey = @"kjerhifgjherpighirjwhgigwh8927r-9#$%¨SDF$$%";

        public string EncryptMD5(string text)
        {
            string result = null;

            MD5 md5Hash = MD5.Create();

            byte[] textBytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

            for (int i = 0; i < textBytes.Length; i++)
            {
                result += textBytes[i].ToString("x2");
            }

            return result;
        }

        public string EncryptTripleDES(string text)
        {
            string result;

            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            byte[] keyBytes = Encoding.UTF8.GetBytes(encryptKey);

            SHA256CryptoServiceProvider HashProvider = new SHA256CryptoServiceProvider();
            byte[] temp = HashProvider.ComputeHash(keyBytes);
            byte[] key = new byte[24];
            Array.Copy(temp, key, 24);

            TripleDESCryptoServiceProvider TripleDesProvider = new TripleDESCryptoServiceProvider();
            TripleDesProvider.Key = key;
            TripleDesProvider.Mode = CipherMode.ECB;
            TripleDesProvider.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = TripleDesProvider.CreateEncryptor();

            byte[] resultBytes = cTransform.TransformFinalBlock(textBytes, 0, textBytes.Length);

            result = Convert.ToBase64String(resultBytes);

            return result;
        }

        public string DecryptTrypleDES(string text)
        {
            text = text.Replace(" ", "+");
            string result = null;

            byte[] textBytes = Convert.FromBase64String(text);
            byte[] keyBytes = Encoding.UTF8.GetBytes(encryptKey);

            SHA256CryptoServiceProvider HashProvider = new SHA256CryptoServiceProvider();
            byte[] temp = HashProvider.ComputeHash(keyBytes);
            byte[] key = new byte[24];
            Array.Copy(temp, key, 24);

            TripleDESCryptoServiceProvider TripleDesProvider = new TripleDESCryptoServiceProvider();
            TripleDesProvider.Key = key;
            TripleDesProvider.Mode = CipherMode.ECB;
            TripleDesProvider.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = TripleDesProvider.CreateDecryptor();

            byte[] resultArray = cTransform.TransformFinalBlock(textBytes, 0, textBytes.Length);

            result = Encoding.UTF8.GetString(resultArray);

            return result;
        }
    }
}
