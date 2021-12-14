using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestCrud.Models.Helper
{
    public class Helpper
    {


        public static bool  IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"\+?1?\s*\(?-*\.*(\d{3})\)?\.*-*\s*(\d{3})\.*-*\s*(\d{4})$").Success;
        }

        public static bool IsvalidateAccountNumber(string number)
        {
            return Regex.Match(number, @"/^[0-9]{2}(?:[0-9]{9}|-[0-9]{3}-[0-9]{6})$/").Success;
        }




        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
