using System.Text.RegularExpressions;
using System;
namespace NETCORE.Models
{
    public class StringProcess
    {
        public string GenerateKey (string id) {
            string strkey = "";
            string numPart = "", strPart = "";
            numPart = Regex.Match (id, @"\d+").Value;
            strPart = Regex.Match (id, @"\D+").Value;
            int intPart = (Convert.ToInt32(numPart) + 1);
            for(int i = 0; i < numPart.Length - intPart.ToString().Length; i++)
            {
                strPart += "0";
            }
            strkey = strPart + intPart;
            return strkey;
        }
    }
}