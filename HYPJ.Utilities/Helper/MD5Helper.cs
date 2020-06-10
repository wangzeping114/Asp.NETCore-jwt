using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace HYPJ.Utilities.Helper
{
    public class MD5Helper
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string MD5Hash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                var strResult = BitConverter.ToString(result);
                return strResult.Replace("-", "").ToLowerInvariant();
            }
        }
        /// <summary>
        /// 对文件流进行MD5加密
        /// </summary>
        public static string ComputeContentMd5(string filepath)
        {
            StringBuilder sb = new StringBuilder();
            using (var fs = File.OpenRead(filepath))
            {
                using (var md5Hash = MD5.Create())
                {
                    byte[] bytes = md5Hash.ComputeHash(fs);
                    foreach (var b in bytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                }
            }
            return sb.ToString();
        }
    }
}

