using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LisenceFile
{
    class LisenceSign
    {   


        byte[] Sign(byte[] data, string PrivateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //导入私钥，准备签名
            rsa.FromXmlString(PrivateKey);
            //将数据使用MD5进行消息摘要，然后对摘要进行签名并返回签名数据
            return rsa.SignData(data, "MD5");
        }


        public string Sign(string Text, String PrivateKey)
        {
            var data = System.Text.Encoding.UTF8.GetBytes(Text);

            var data_result = Sign(data, PrivateKey);

            return Convert.ToBase64String(data_result);
        }

        bool Verify(byte[] data, byte[] Signature, string PublicKey)
        {   
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //导入公钥，准备验证签名
            rsa.FromXmlString(PublicKey);
            //返回数据验证结果
            return rsa.VerifyData(data, "MD5", Signature);
        }

        public bool Verify(String Text, string SignatureBase64, string PublicKey)
        {   
            var data = System.Text.Encoding.UTF8.GetBytes(Text);
            byte[] Signature = Convert.FromBase64String(SignatureBase64);

            return Verify(data, Signature, PublicKey);

        }
    }
}
