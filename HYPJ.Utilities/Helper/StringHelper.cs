using System;
using System.Text;

namespace HYPJ.Utilities.Helper
{
    public class StringHelper
    {
        public static string GetNonceString(int len = 6)
        {
            var chars = "0123456789ABCDEFGHIJKMNPQRSTUVWXYZ";
            var sb = new StringBuilder(len);
            Random rd = new Random();
            for (int i = 0; i < len; i++)
            {
                sb.Append(chars[rd.Next(chars.Length)]);
            }
            return sb.ToString();
        }
    }
}
