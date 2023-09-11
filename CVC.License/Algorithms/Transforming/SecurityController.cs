﻿using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Reflection;

namespace CVC.License.Algorithms.Transforming
{
    public class SecurityController
    {
        ErrorManagement errorManagement = new ErrorManagement();
        public string Encrypt(string key, string data)
        {
            string encData = null;

            try
            {
                byte[][] keys = GetHashKeys(key);
                encData = EncryptStringToBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            catch (ArgumentNullException ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return encData;
        }
        public string Decrypt(string key, string data)
        {
            string decData = null;

            try
            {
                byte[][] keys = GetHashKeys(key);
                decData = DecryptStringFromBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            catch (ArgumentNullException ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return decData;
        }
        private byte[][] GetHashKeys(string key)
        {
            byte[][] result = new byte[2][];
            try
            {
                if (!string.IsNullOrWhiteSpace(key))
                {
                    Encoding enc = Encoding.UTF8;
                    SHA256 sha2 = new SHA256CryptoServiceProvider();
                    byte[] rawKey = enc.GetBytes(key);
                    byte[] rawIV = enc.GetBytes(key);
                    byte[] hashKey = sha2.ComputeHash(rawKey);
                    byte[] hashIV = sha2.ComputeHash(rawIV);
                    Array.Resize(ref hashIV, 16);
                    result[0] = hashKey;
                    result[1] = hashIV;
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return result;
        }
        //source: https://msdn.microsoft.com/de-de/library/system.security.cryptography.aes(v=vs.110).aspx
        private static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            string Content = null;
            try
            {
                if (plainText == null || plainText.Length <= 0)
                    throw new ArgumentNullException("plainText");
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");
                byte[] encrypted;
                using (AesManaged aesAlg = new AesManaged())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }
                }
                Content = Convert.ToBase64String(encrypted);
            }
            catch (SystemException ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Content;
        }
        //source: https://msdn.microsoft.com/de-de/library/system.security.cryptography.aes(v=vs.110).aspx
        private static string DecryptStringFromBytes_Aes(string cipherTextString, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            try
            {
                if (!string.IsNullOrWhiteSpace(cipherTextString))
                {
                    byte[] cipherText = Convert.FromBase64String(cipherTextString);
                    if (cipherText == null || cipherText.Length <= 0)
                        throw new ArgumentNullException("cipherText");
                    if (Key == null || Key.Length <= 0)
                        throw new ArgumentNullException("Key");
                    if (IV == null || IV.Length <= 0)
                        throw new ArgumentNullException("IV");
                    using (Aes aesAlg = Aes.Create())
                    {
                        aesAlg.Key = Key;
                        aesAlg.IV = IV;
                        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                        using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                        {
                            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                            {
                                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                                {
                                    plaintext = srDecrypt.ReadToEnd();
                                }
                            }
                        }
                    }
                }
            }
            catch (SystemException ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return plaintext;
        }
    }
}
