using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace ZKTecoDown
{
    internal struct InitData
    {
        public string Company;
        public int MachineQuant;
        public string DatabasePath;
        public string RecordPath;
    }

    internal class Config
    {
        
        public static InitData initconf { get; private set; }
        private Config()
        {

        }

        public static bool Initialize(string path2ini)
        {
            try
            {
                using (FileStream iniFile = new FileStream(path2ini, FileMode.Open, FileAccess.Read))
                { 
                    iniFile.Seek(0, SeekOrigin.Begin);
                    byte[] data = new byte[iniFile.Length-16];
                    byte[] nonce = new byte[16];
                    byte[] tag = new byte[16];
                    iniFile.Read(nonce, 0, 16);
                    iniFile.Read(data, 0, data.Length);
                    
                    byte[] key = ASCIIEncoding.ASCII.GetBytes("u9120bkb");
                   
                    var hasher = MD5.Create();
                    var HashedKey = hasher.ComputeHash(key);
                    var dataString = DecryptStringFromBytes_Aes(data, HashedKey, nonce);
                    initconf = JsonConvert.DeserializeObject<InitData>(dataString);

                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
                return false;
            }
            
            return true;
        }

        private static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            
            string plaintext;

            using (var aes = Aes.Create())
            {
                aes.BlockSize = 128;
                aes.Key = Key;
                aes.Mode = CipherMode.CFB;
                aes.IV = IV;
                aes.Padding = PaddingMode.None;
                
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (var msDecrypt = new MemoryStream(cipherText))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new StreamReader(csDecrypt))
                    plaintext = srDecrypt.ReadToEnd();
            }

            return plaintext;
        }

    }
}
