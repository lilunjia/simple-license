using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace LisenceFile
{
    class VersionSettingsManager
    {

        /// <summary>
        /// 用于存储证书的基础路径
        /// </summary>
        public string StorePath
        {
            get
            {
                string temp = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Store");

                if (Directory.Exists(temp) == false)
                    Directory.CreateDirectory(temp);

                return temp;
            }
        }

        private VersionSettingsManager()
        { }

        private static VersionSettingsManager _instance = null;
        public static VersionSettingsManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VersionSettingsManager();
                }
                return _instance;
            }
        }
        public bool Delete(string Name)
        {
            var dir = Path.Combine(this.StorePath, Name);

            if (Directory.Exists(dir))
            {
                Directory.Delete(dir, true);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Create(string Name)
        {
            var dir = Path.Combine(this.StorePath, Name);

            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

                using (StreamWriter writer = new StreamWriter(Path.Combine(dir, "私钥[" + Name + "].dat")))  //这个文件要保密...
                {   
                    writer.WriteLine(rsa.ToXmlString(true));
                }

                using (StreamWriter writer = new StreamWriter(Path.Combine(dir, "公钥[" + Name + "].dat")))
                {   
                    writer.WriteLine(rsa.ToXmlString(false));
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        public string[] List()
        {
            List<string> result = new List<string>();

            var items = Directory.GetDirectories(this.StorePath);
            foreach (string item in items)
            {
                DirectoryInfo di = new DirectoryInfo(item);
                result.Add(di.Name);
            }

            return result.ToArray();
        }

        /// <summary>
        /// 读取公钥信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public string ReadPublicKey(string Name)
        {   
            var dir = Path.Combine(this.StorePath, Name);

            var path = Path.Combine(dir, "公钥[" + Name + "].dat");

            return File.ReadAllText(path);
        }

        /// <summary>
        /// 读取私钥信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public string ReadPrivateKey(string Name)
        {   
            var dir = Path.Combine(this.StorePath, Name);

            var path = Path.Combine(dir, "私钥[" + Name + "].dat");

            return File.ReadAllText(path);
        }

    }
}
