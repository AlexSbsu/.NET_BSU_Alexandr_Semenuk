using System;
namespace Study_HomeWork_8
{
    static class PhoneHelper
    {
        public static bool IsPhoneValid(string s)
        {
            if (!s.StartsWith("+") || (s.Length!=13)) return false;
            //if ((s.Length != 13)) return false;
            for (int i=1; i<s.Length;i++) if (!char.IsDigit(s[i])) return false;
            return true;
        }

        static PhoneHelper()
        {

        }
    }
}
