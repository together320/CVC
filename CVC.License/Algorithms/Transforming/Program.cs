using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.IO;
namespace CVC.License.Algorithms.Transforming
{
    class Program
    {
        static string FilePath_Public = @"D:\lee\Person\RSA\RSAPUBLICKEY.xml";
        static string FilePath_Private = @"D:\lee\Person\RSA\RSAPRIVATEKEY.xml";
        static string publicKeyString = null;
        static string privateKeyString = null;
        static void Main(string[] args)
        {
            //DECLARATION
            KeyManagement keyManagement = new KeyManagement();

            //RSA PUBLIC KEYS
            //===========================================================================================
            if (File.Exists(FilePath_Public))
                publicKeyString = File.ReadAllText(FilePath_Public);
            else
            {
                Console.WriteLine("RSA PUBLIC KEY IS NOT AVAILABLE");
            }
            if (publicKeyString == null || publicKeyString.Trim().Length < 10)
            {
                Console.WriteLine("Public key is not valid");
            }

            //===========================================================================================
            //RSA PRIVATE KEY
            //===========================================================================================
            if (File.Exists(FilePath_Private))
                privateKeyString = File.ReadAllText(@"D:\lee\Person\RSA\RSAPRIVATEKEY.xml");
            else
            {
                Console.WriteLine("RSA PRIVATE KEY IS NOT AVAILABLE");
            }
            if (privateKeyString == null || privateKeyString.Trim().Length <10)
            {
                Console.WriteLine("Private key is not valid");
            }
            //===========================================================================================

            //DISPLAYING KEYS
            Console.WriteLine("Public Key:");
            Console.WriteLine(publicKeyString);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Private key:");
            Console.WriteLine(privateKeyString);
            Console.WriteLine("-------------------------------------------");

            //LICENCE KEY CONTENT TO ENCRYPT
            string textToEncrypt = "Welcome to OOty Nice to meet You !!";
            Console.WriteLine("Test Data:");
            Console.WriteLine(textToEncrypt);
            Console.WriteLine("-------------------------------------------");

            //ENCRYTPTED LICENSE KEY CONTENT
            string encryptedText = keyManagement.Encrypt(textToEncrypt, publicKeyString); 
            Console.WriteLine("Encrypted TEXT:");
            Console.WriteLine(encryptedText);
            Console.WriteLine("-------------------------------------------");

            //DECRYPTED LICENSE KEY COMTENT
            string decryptedText = keyManagement.Decrypt(encryptedText, privateKeyString);
            Console.WriteLine("Decrypted TEXT:");
            Console.WriteLine(decryptedText);



            Console.ReadLine();
        }
    }
}
