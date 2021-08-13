using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace AES_Tool
{
    static public class AES
    {
        static public string AES_Encryptor(string plain_text, int key_size, string key, string IV, string cipher_mode, string padding_mode)
        {
            AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();

            if (key_size != 16 && key_size != 24 && key_size != 32)
            {
                throw new Exception("Wrong Block Size.");
            }

            aesCryptoServiceProvider.BlockSize = 128;
            aesCryptoServiceProvider.KeySize = key_size * 8;
            if (IV != "")
            {
                aesCryptoServiceProvider.IV = Encoding.UTF8.GetBytes(IV);
            }

            aesCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(key);

            switch (cipher_mode)
            {
                case "CBC":
                    aesCryptoServiceProvider.Mode = CipherMode.CBC;
                    break;
                case "ECB":
                    aesCryptoServiceProvider.Mode = CipherMode.ECB;
                    break;
                case "CFB":
                    aesCryptoServiceProvider.Mode = CipherMode.CFB;
                    break;
                default:
                    throw new Exception("Wrong Cipher Mode");
            }
            switch (padding_mode)
            {
                case "None":
                    aesCryptoServiceProvider.Padding = PaddingMode.None;
                    break;
                case "PKCS7":
                    aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                    break;
                case "Zeros":
                    aesCryptoServiceProvider.Padding = PaddingMode.Zeros;
                    break;
                case "ANSIX923":
                    aesCryptoServiceProvider.Padding = PaddingMode.ANSIX923;
                    break;
                case "ISO10126":
                    aesCryptoServiceProvider.Padding = PaddingMode.ISO10126;
                    break;
                default:
                    throw new Exception("Wrong Padding Mode");
            }
            byte[] plain_text_bytes = Encoding.UTF8.GetBytes(plain_text);
            using (ICryptoTransform encrypt = aesCryptoServiceProvider.CreateEncryptor())
            {
                byte[] bytes = encrypt.TransformFinalBlock(plain_text_bytes, 0, plain_text_bytes.Length);
                return Convert.ToBase64String(bytes);
            }
        }
        static public string AES_Decryptor(string cipher_text, int key_size, string key, string IV, string cipher_mode, string padding_mode)
        {
            AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();

            if (key_size != 16 && key_size != 24 && key_size != 32)
            {
                throw new Exception("Wrong Block Size.");
            }

            aesCryptoServiceProvider.BlockSize = 128;
            aesCryptoServiceProvider.KeySize = key_size * 8;

            if (IV != "")
            {
                aesCryptoServiceProvider.IV = Encoding.UTF8.GetBytes(IV);
            }
            aesCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(key);

            switch (cipher_mode)
            {
                case "CBC":
                    aesCryptoServiceProvider.Mode = CipherMode.CBC;
                    break;
                case "ECB":
                    aesCryptoServiceProvider.Mode = CipherMode.ECB;
                    break;
                case "CFB":
                    aesCryptoServiceProvider.Mode = CipherMode.CFB;
                    break;
                default:
                    throw new Exception("Wrong Cipher Mode");
            }
            switch (padding_mode)
            {
                case "None":
                    aesCryptoServiceProvider.Padding = PaddingMode.None;
                    break;
                case "PKCS7":
                    aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                    break;
                case "Zeros":
                    aesCryptoServiceProvider.Padding = PaddingMode.Zeros;
                    break;
                case "ANSIX923":
                    aesCryptoServiceProvider.Padding = PaddingMode.ANSIX923;
                    break;
                case "ISO10126":
                    aesCryptoServiceProvider.Padding = PaddingMode.ISO10126;
                    break;
                default:
                    throw new Exception("Wrong Padding Mode");
            }
            byte[] cipher_text_bytes = Convert.FromBase64String(cipher_text);
            using (ICryptoTransform decrypt = aesCryptoServiceProvider.CreateDecryptor())
            {
                try
                {
                    byte[] result = decrypt.TransformFinalBlock(cipher_text_bytes, 0, cipher_text_bytes.Length);
                    return Encoding.UTF8.GetString(result);
                }
                catch (CryptographicException)
                {
                    MessageBox.Show("Check the Key or IV.");
                    return null;
                }
            }
        }
        static public byte[] AES_File_Encryptor(string file_location, int key_size, string key, string IV, string cipher_mode, string padding_mode)
        {
            AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();

            if (key_size != 16 && key_size != 24 && key_size != 32)
            {
                throw new Exception("Wrong Block Size.");
            }

            aesCryptoServiceProvider.BlockSize = 128;
            aesCryptoServiceProvider.KeySize = key_size * 8;
            if (IV != "")
            {
                aesCryptoServiceProvider.IV = Encoding.UTF8.GetBytes(IV);
            }

            aesCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(key);

            switch (cipher_mode)
            {
                case "CBC":
                    aesCryptoServiceProvider.Mode = CipherMode.CBC;
                    break;
                case "ECB":
                    aesCryptoServiceProvider.Mode = CipherMode.ECB;
                    break;
                case "CFB":
                    aesCryptoServiceProvider.Mode = CipherMode.CFB;
                    break;
                default:
                    throw new Exception("Wrong Cipher Mode");
            }
            switch (padding_mode)
            {
                case "None":
                    aesCryptoServiceProvider.Padding = PaddingMode.None;
                    break;
                case "PKCS7":
                    aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                    break;
                case "Zeros":
                    aesCryptoServiceProvider.Padding = PaddingMode.Zeros;
                    break;
                case "ANSIX923":
                    aesCryptoServiceProvider.Padding = PaddingMode.ANSIX923;
                    break;
                case "ISO10126":
                    aesCryptoServiceProvider.Padding = PaddingMode.ISO10126;
                    break;
                default:
                    throw new Exception("Wrong Padding Mode");
            }
            byte[] plain_text_bytes = File.ReadAllBytes(file_location);
            using (ICryptoTransform encrypt = aesCryptoServiceProvider.CreateEncryptor())
            {
                byte[] bytes = encrypt.TransformFinalBlock(plain_text_bytes, 0, plain_text_bytes.Length);
                return bytes;
            }
        }
        static public byte[] AES_File_Decryptor(string file_location, int key_size, string key, string IV, string cipher_mode, string padding_mode)
        {
            AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();

            if (key_size != 16 && key_size != 24 && key_size != 32)
            {
                throw new Exception("Wrong Block Size.");
            }

            aesCryptoServiceProvider.BlockSize = 128;
            aesCryptoServiceProvider.KeySize = key_size * 8;

            if (IV != "")
            {
                aesCryptoServiceProvider.IV = Encoding.UTF8.GetBytes(IV);
            }
            aesCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(key);

            switch (cipher_mode)
            {
                case "CBC":
                    aesCryptoServiceProvider.Mode = CipherMode.CBC;
                    break;
                case "ECB":
                    aesCryptoServiceProvider.Mode = CipherMode.ECB;
                    break;
                case "CFB":
                    aesCryptoServiceProvider.Mode = CipherMode.CFB;
                    break;
                default:
                    throw new Exception("Wrong Cipher Mode");
            }
            switch (padding_mode)
            {
                case "None":
                    aesCryptoServiceProvider.Padding = PaddingMode.None;
                    break;
                case "PKCS7":
                    aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                    break;
                case "Zeros":
                    aesCryptoServiceProvider.Padding = PaddingMode.Zeros;
                    break;
                case "ANSIX923":
                    aesCryptoServiceProvider.Padding = PaddingMode.ANSIX923;
                    break;
                case "ISO10126":
                    aesCryptoServiceProvider.Padding = PaddingMode.ISO10126;
                    break;
                default:
                    throw new Exception("Wrong Padding Mode");
            }
            byte[] cipher_text_bytes = File.ReadAllBytes(file_location);
            using (ICryptoTransform decrypt = aesCryptoServiceProvider.CreateDecryptor())
            {
                try
                {
                    byte[] result = decrypt.TransformFinalBlock(cipher_text_bytes, 0, cipher_text_bytes.Length);
                    return result;
                }
                catch(CryptographicException)
                {
                    MessageBox.Show("Check the Key or IV.");
                    return null;
                }
            }
        }
    }
}
