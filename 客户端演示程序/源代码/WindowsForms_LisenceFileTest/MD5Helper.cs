using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


public class MD5Helper
{
    private static MD5 md5 = MD5.Create();

    //使用utf8编码将字符串散列
    public static string GetMD5HashString(string sourceStr)
    {
        return GetMD5HashString(Encoding.UTF8, sourceStr);
    }

    //使用指定编码将字符串散列
    public static string GetMD5HashString(Encoding encode, string sourceStr)
    {
        StringBuilder sb = new StringBuilder();

        byte[] source = md5.ComputeHash(encode.GetBytes(sourceStr));
        for (int i = 0; i < source.Length; i++)
        {
            sb.Append(source[i].ToString("x2"));
        }

        return sb.ToString();
    }
}

