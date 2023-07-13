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
            //--------------------------------------------------------------HW5-1c EXCEPTION
            try
            {
                 for (int i = 0; i < char_ar.Length; i++) sb.Replace(Convert.ToString((char)char_ar[i]), "");
            }
            catch (Exception e) { Console.WriteLine("!!!EXCEPTION DEFUALT punctuation_rem Message : " + e.Message); }
            return sb.ToString();
        }
        public string add_symbToend(string s,string s1)
        {
            StringBuilder sb = new StringBuilder(s);
            //--------------------------------------------------------------HW5-1c EXCEPTION
            try { sb.Append(s1);}
            catch (Exception e) { Console.WriteLine("!!!EXCEPTION DEFUALT add_symbToen Message : " + e.Message); }
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
            try { for (int i = s.Length - 1; i >= 0; i--) sb.Append(s[i]); }
            catch (Exception e) { Console.WriteLine("!!!EXCEPTION DEFUALT string_revert Message : " + e.Message); }
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
            //--------------------------------------------------------------HW5-1c EXCEPTION
            try
            {
                Console.WriteLine("Result string punctuation remove : " + strmod.punctuation_rem("!ab.c?"));
                Console.WriteLine("Result string add string to end : " + strmod.add_symbToend("abc ", "cde"));
                Console.WriteLine("Result string replase to upper: " + strmod.replaceTOupper("abc"));
                Console.WriteLine("Result string remove spaces: " + strmod.startEnd_trim(" abc "));
                Console.WriteLine("Result string revert string: " + strmod.string_revert("abc"));
            }
            catch (Exception e) { Console.WriteLine("!!!EXCEPTION DEFUALT METHODS GROUP Message : " + e.Message); }

            string del_str = "delegate_string";
            Console.WriteLine("ISEMPTY:" + String.IsNullOrEmpty(del_str));

            try
            {
                strmod.string_delegate_chain(del_str,strmod.str_print, strmod.str_isempty, strmod.replaceTOupper);
            }
            catch (Exception e) { Console.WriteLine("!!!EXCEPTION DEFUALT DELEGATE METHODS Message : " + e.Message); }
            //--------------------------------------2
            //--------------------------------------------------------------HW5-1c EXCEPTION
            try
            {
                Console.WriteLine("Same with lambda: ");
                strmod.string_delegate_chain(del_str, s => Console.WriteLine(del_str),
                                                s1 => String.IsNullOrEmpty(del_str),
                                                s2 => del_str.ToUpper());
            }
            catch (Exception e) { Console.WriteLine("!!!EXCEPTION DEFUALT DELEGATE METHODS Message : " + e.Message); }
        }
    }
}
