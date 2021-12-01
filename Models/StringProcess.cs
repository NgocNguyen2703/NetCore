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
            numPart = Regex.Match (id, @"\D+").Value;
            int intPart = (Convert.ToInt32(numPart) + 1);
            for(int i = 1; i < numPart.Length - intPart.ToString().Length; i++);
            {
                strPart += "0";
            }
            strkey = strPart + intPart;
            return strkey;
        }
    }
}