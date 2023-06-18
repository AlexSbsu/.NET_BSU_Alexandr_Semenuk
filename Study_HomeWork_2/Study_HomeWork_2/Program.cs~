using System;
using System.Text;

namespace Study_HomeWork_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
//--------------------------------------1a
/*
            int i;
            double d;
            char c;
            bool b;
            string s;

            Console.Write("Enter int i="); i=int.Parse(Console.ReadLine());
            Console.WriteLine("Entered i=" + i);
            Console.Write("Enter double d="); d = double.Parse(Console.ReadLine());
            Console.WriteLine("Entered d=" + d);
            Console.Write("Enter char c="); c = char.Parse(Console.ReadLine());
            Console.WriteLine("Entered c=" + c);
            Console.Write("Enter bool true/false b="); b = bool.Parse(Console.ReadLine());
            Console.WriteLine("Entered b=" + b);
            Console.Write("Enter string="); s = Console.ReadLine();
            Console.WriteLine("Entered s=" + s);

            //Console.WriteLine("i="+i+"\nc="+c+"\ns="+s+"\nb="+b);
            //--------------------------------------1b
            s = Convert.ToString(i);
            s = Convert.ToString(c);
            c = (char)i;
            i = (int)d;
            i = c; //char to int
            d = i; //int to double
                   //--------------------------------------1c
            int i1;
            object o = i; //boxing
            i1 = (int)o;       //unboxing
            Console.WriteLine("i=" + i + " i1=" + i1);
            //--------------------------------------1d
            var va = i;
            Console.WriteLine("va=" + va);
            va = c;
            Console.WriteLine("va=" + va);
            //--------------------------------------1e
            int? intn=1;
            Console.WriteLine("intn=" + intn);
            intn = null;
            Console.WriteLine("intn=" + intn);
            //--------------------------------------1f
            //va = s;  //ERROR va already initialized as of int type
            Console.WriteLine("va=" + va);

            */
            //--------------------------------------2a
            string s;

            string s1 = "string1";
            string s2 = "S_t_R_i_N_g_2";
            string s3 = "S T R I N G 3";

            //Concat
            s=string.Concat(s1,s2);
            Console.WriteLine("s=" + s);
            s += s;
            Console.WriteLine("s=" + s);
            //Copy
            s = string.Copy(s3);
            Console.WriteLine("s=" + s);
            //Substr select
            s = s2.Substring(3);
            Console.WriteLine("s=" + s);
            //Split
            s = string.Concat(s1,"!", s2, "!", s3);
            Console.WriteLine("s=" + s);
            string[] sa = s.Split('!');
            foreach(string st in sa) Console.WriteLine(" st=" + st);
            //Insert
            s = s1.Insert(s1.Length-1,"QQQQ");
            string st1 = "QQQQ";
            Console.WriteLine("Inserted s=" + s);
            s=s.Remove(s.IndexOf(st1),st1.Length);
            Console.WriteLine("s=" + s);
            //String Interpolation
            int iss= 22; char cs = '=';
            s = $"s{cs}{iss}";
            Console.WriteLine("Interpoliren : " + s);
            //--------------------------------------2b
            string se = "";
            string sn = null;
            if (string.IsNullOrEmpty(se)) Console.WriteLine("se is null or empty");
            bool bs = string.IsNullOrEmpty(sn);
            if (bs) Console.WriteLine("sn is null or empty");
            //--------------------------------------2c
            StringBuilder stb = new StringBuilder("qqq3www7e9");
            stb.Remove(9,1);
            stb.Remove(7,1);
            stb.Remove(3, 1);
            stb.Insert(0,"START");
            stb.Append("END");
            Console.WriteLine("stb=" + stb);
            //--------------------------------------3a
            (int, char, string, ulong) tuple1 = (1,'d',"string1",10001);
            (int, char, string, ulong) tuple2 = (2,'f',"string2",20002);
            (int, char, string, ulong) tuple3 = (2,'f',"string2",20002);
            //--------------------------------------3b
            Console.WriteLine("tuple1=" + tuple1);
            Console.WriteLine("Item1="+tuple1.Item1+" Item2="+tuple1.Item2+" Item3="+tuple1.Item3+" Item4="+tuple1.Item4);
            Console.WriteLine("Item1="+tuple1.Item1+" Item3="+tuple1.Item3+" Item4="+tuple1.Item4);

            //--------------------------------------3c
            object ot;
            (int, char, string, ulong) t;
            ot = tuple1;
            t = (ValueTuple<int, char, string, ulong>)ot;
            Console.WriteLine("tuple t=" + t);
            //--------------------------------------3d
            //need C#>=7.3
            //if (tuple1 == tuple2) Console.WriteLine("ТУПЛЫ tuple1 и tuple2 равны");
            //else Console.WriteLine("ТУПЛЫ tuple1 и tuple2 НЕ равны");
            if (tuple2.Equals(tuple3)) Console.WriteLine("EQUAL(tuple2 and tuple3)");
            else Console.WriteLine("NOT EQUAL(tuple2 and tuple3)");
        }
    }
}
