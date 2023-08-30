using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_9
{
        static class PhoneHelper
        {
            public static bool IsPhoneValid(string s)
            {
                if (!s.StartsWith("+") || (s.Length != 13)) return false;
                //if ((s.Length != 13)) return false;
                for (int i = 1; i < s.Length; i++) if (!char.IsDigit(s[i])) return false;
                return true;
            }

            static PhoneHelper()
            {

            }
        }
}
