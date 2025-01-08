using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hospital.Bl.ExtensionMethods
{
    public static class ExtensionMethod
    {
        public static bool IsValidEmail(this string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        public static bool IsValidPhoneNumber(this string phoneNumber)
        {
            Regex regex = new Regex(@"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}");
            Match match = regex.Match(phoneNumber);
            if(match.Success){
                return true;
            }
            return false;
        }
       


    }

}
