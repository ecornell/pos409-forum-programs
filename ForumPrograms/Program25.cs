using System;
using System.Security.Cryptography;
using System.Text;

namespace ForumPrograms {

    public class Program25 {

        static void Main(string[] args) {

            string plainText = "This in my sample text string.";
            string secretKey = "secret-key";

            Console.WriteLine("Input value: {0}", plainText);

            // Crypto setup
            HashAlgorithm sha = SHA256.Create();
            SymmetricAlgorithm cryptoAlgorythm = SymmetricAlgorithm.Create("Aes");

            byte[] plainDataIn = Encoding.Default.GetBytes(plainText);
            byte[] key = sha.ComputeHash(Encoding.Default.GetBytes(secretKey.ToString()));
            byte[] IV = Encoding.Default.GetBytes("1234567812345678"); // 16 bytes - blocksize/8

            // Encrypt text
            ICryptoTransform encryptor = cryptoAlgorythm.CreateEncryptor(key, IV);
            byte[] cipherData = encryptor.TransformFinalBlock(plainDataIn, 0, plainDataIn.Length);

            Console.WriteLine("Encrypted value (Base64): {0}", Convert.ToBase64String(cipherData));

            // Decrypt text
            ICryptoTransform decryptor = cryptoAlgorythm.CreateDecryptor(key, IV);
            byte[] plainDataOut = decryptor.TransformFinalBlock(cipherData, 0, cipherData.Length);

            Console.WriteLine("Decrypted value: {0}", System.Text.Encoding.UTF8.GetString(plainDataOut));

            // Crypto cleanup
            cryptoAlgorythm.Clear();

            //--            
            Console.ReadKey();
        }
    }
}


// Ref: SecureString - https://msdn.microsoft.com/en-us/library/system.security.securestring.aspx





  //private static SecureString getInput() {
  //          SecureString securePwd = new SecureString();
  //          ConsoleKeyInfo key;
  //          Console.Write("Enter password: ");
  //          do {
  //              key = Console.ReadKey(true);

  //              if (((int)key.Key) >= 65 && ((int)key.Key <= 90)) {
  //                  securePwd.AppendChar(key.KeyChar);
  //                  Console.Write("*");
  //              }
  //          } while (key.Key != ConsoleKey.Enter);
  //          return securePwd;
  //      }