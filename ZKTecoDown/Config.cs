using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Text;

namespace ZKTecoDown
{
    internal struct InitData
    {
        public string Company;
        public int MachineQuant;
        public int[] DLTime;
        public string DatabasePath;
        public string LogsPath;

        public InitData()
        {
            Company = "Default";
            MachineQuant = 0;
            DLTime = new int[2];
            DatabasePath = "";
            LogsPath = "";
        }
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
                using (FileStream iniFile = new(path2ini, FileMode.Open, FileAccess.Read))
                { 
                    byte[] data = new byte[iniFile.Length-16];
                    byte[] nonce = new byte[16];

                    iniFile.Seek(0, SeekOrigin.Begin);
                    iniFile.Read(nonce, 0, 16);
                    iniFile.Read(data, 0, data.Length);
                    
                    byte[] key = ASCIIEncoding.ASCII.GetBytes("u9120bkb");
                   
                    var hasher = MD5.Create();
                    var HashedKey = hasher.ComputeHash(key);
                    var dataString = DecryptStringFromBytes_Aes(data, HashedKey, nonce);

                    initconf = JsonConvert.DeserializeObject<InitData>(dataString);

                    var tempConf = initconf;
                    tempConf.DatabasePath = Environment.ExpandEnvironmentVariables(initconf.DatabasePath);
                    tempConf.LogsPath = Environment.ExpandEnvironmentVariables(initconf.LogsPath);
                    initconf = tempConf;

                    Directory.CreateDirectory(initconf.DatabasePath);
                    Directory.CreateDirectory(initconf.LogsPath);


                }
            }
            catch (Exception ex)
            { 
                Debug.WriteLine("Exception at Config.Initialize" + ex.ToString());
                MessageBox.Show("Error en inicializacion. Revise la configuracion del programa.", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
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
