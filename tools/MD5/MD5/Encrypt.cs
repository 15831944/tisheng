using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
namespace MD5
{
    public class Encrypt
    {
        public static string Encrypt_MD5(string password)
        {
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] result = Encoding.Default.GetBytes(password);
            byte[] output = md5.ComputeHash(result);
            StringBuilder sb = new StringBuilder();
            for(int i= 0; i < output.Length; i++)
            {
                sb.Append(output[i].ToString("x"));
            }
            return sb.ToString().ToLower();
        }
        //安卓 “123” “202cb962ac59075b964b07152d234b70”
    }
}
