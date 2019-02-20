using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.WCFInspector
{
    public class TokenStatic
    {
        public static void SetToken(string token)
        {
            DefaultToken = token;
        }
        public static string GetToken()
        {
            return DefaultToken;
        }
        private static string DefaultToken = "";
    }
}
