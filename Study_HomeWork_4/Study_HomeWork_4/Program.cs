using System;
using System.Text;

namespace Study_HomeWork_4
{
    public class string_mod
    {
        //--------------------------------------1a
        public string punctuation_rem(string s)
        {
            // ".-46"  "?-63"  "!-33"  ",-44"  ";-59"  ":-58"  "— - 45" "(-40" ")-41"  "«-171" "»-187"
            int[] char_ar = { 46, 63, 33, 44, 59, 58, 45, 40, 41, 171, 187 };
            StringBuilder sb = new StringBuilder(s);
            //for (int i = 0; i < char_ar.Length; i++) Console.WriteLine(char_ar[i].ToString() + " " + (char)char_ar[i]);

            for (int i = 0; i < char_ar.Length; i++) sb.Replace(Convert.ToString((char)char_ar[i]), "");
            return sb.ToString();
        }
        public string add_symbToend(string s,string s1)
        {
            StringBuilder sb = new StringBuilder(s);
            sb.Append(s1);
            return sb.ToString();
        }
        public string replaceTOupper(string s)
        {
            StringBuilder sb = new StringBuilder(s.ToUpper());
            return sb.ToString();
        }
        public string startEnd_trim(string s)
        {
            StringBuilder sb = new StringBuilder(s.Trim());
            return sb.ToString();
        }
        public string string_revert(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
                sb.Append(s[i]);
            return sb.ToString();
        }
        public bool str_isempty(string s)
        {
            return s.Length==0;
        }
        public void str_print(string s)
        {
            Console.WriteLine("string is : " + s);
        }
        //--------------------------------------1b
        public void string_delegate_chain(string s, Action<string> act_str,Predicate<string> pred_str,Func<string, string> func_str)
        {
            act_str(s);
            Console.WriteLine("is String empty: " + pred_str(s));
            Console.WriteLine("string action: " + func_str(s));         
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            string_mod strmod = new string_mod();
            Console.WriteLine("Result string punctuation remove : "+ strmod.punctuation_rem("!ab.c?"));
            Console.WriteLine("Result string add string to end : " + strmod.add_symbToend("abc ","cde"));
            Console.WriteLine("Result string replase to upper: " + strmod.replaceTOupper("abc"));
            Console.WriteLine("Result string remove spaces: " + strmod.startEnd_trim(" abc "));
            Console.WriteLine("Result string revert string: " + strmod.string_revert("abc"));

            string del_str = "delegate_string";
            Console.WriteLine("ISEMPTY:" + String.IsNullOrEmpty(del_str));

            strmod.string_delegate_chain(del_str,strmod.str_print, strmod.str_isempty, strmod.replaceTOupper);

            //--------------------------------------2
            Console.WriteLine("Same with lambda: ");
            strmod.string_delegate_chain(del_str,s => Console.WriteLine(del_str), s1 => String.IsNullOrEmpty(del_str), s2 => del_str.ToUpper());
        }
    }
}
