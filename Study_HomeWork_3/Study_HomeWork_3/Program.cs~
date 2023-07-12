using System;
using System.Collections.Generic;
using System.Linq;

namespace Study_HomeWork_3
{
    public class months
    {
        public string name { get; set; }
        public string season { get; set; }
        public int order { get; set; }
        public months(string n, string s, int o) { name = n; season = s; order = o; }
    }
    public class month_sum
    {
        public month_sum(string m, int n) { month_name = m; amount = n; }
        public string month_name { get; set; }
        public int amount { get; set; }
    }

    enum mymonth_enum {January=1,February,March,April,June,July,August,May,December,September,October,November};

    class MainClass
    {
        public static void Main(string[] args)
        {
            //--------------------------------------1a
            try 
            {
                int[,] ar = new int[,] { { 1, 1, 1 }, { 2, 2, 2 } };
                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    for (int j = 0; j < ar.GetLength(1); j++) Console.Write(ar[i, j] + " ");
                    Console.WriteLine();
                }
            }
            catch (IndexOutOfRangeException nre) { Console.WriteLine("!!!EXCEPTION ar[i, j] IndexOutOfRangeException Message : " + nre.Message); }
            catch (Exception e) { Console.WriteLine("!!!EXCEPTION DEFUALT ar[i, j] Message : " + e.Message); }
            //--------------------------------------1b
            int[] ar1, ar2;
            ar1 = new int[] { 1, 1, 1 };
            Console.WriteLine("ar1");
            for (int i = 0; i < ar1.Length; i++) Console.Write(ar1[i]);
            ar2 = ar1;
            if (ar1.Equals(ar2)) Console.WriteLine("\n ar1 Equal to ar2");
            else Console.WriteLine("\n ar1 NON Equal to ar2");

            Console.WriteLine("\nar2");
            for (int i = 0; i < ar1.Length; i++) Console.Write(ar2[i]);
            Console.WriteLine("\nar2");
            ar2 = new int[] { 2, 2, 2 };
            Console.WriteLine();
            for (int i = 0; i < ar1.Length; i++) Console.Write(ar2[i]);
            if (ar1.Equals(ar2)) Console.WriteLine("\n ar1 Equal to ar2");
            else Console.WriteLine("ar1 NON Equal to ar2");
            //--------------------------------------1c
            //--------------------------------------------------------------HW5-1c
            try
            {
                string[] sar = { "!string1!", " string2 ", " @string3@ " };
                foreach (string s in sar) Console.Write(s);
                Console.WriteLine("\nlength = " + sar.Length);

                Console.WriteLine("Enter element to change(1-3):");
                int el = int.Parse(Console.ReadLine());
                //if (el < 1 || el > 3){Console.WriteLine("value must be 1-3");return;}
                Console.WriteLine("Enter replacement string: ");
                sar[el - 1] = Console.ReadLine();
                foreach (string s in sar) Console.Write(s);
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException nre) 
                { Console.WriteLine("!!!EXCEPTION sar[el - 1] = Console.ReadLine(); IndexOutOfRangeException Message : " + nre.Message); }
            catch (Exception e) 
                { Console.WriteLine("!!!EXCEPTION DEFUALT sar[el - 1] = Console.ReadLine(); Message : " + e.Message); }
            //--------------------------------------1d
            double[][] stepar = new double[][]
            {
                new double[] {1,1},
                new double[] { 2,2,2},
                new double[] { 3,3,3}
            };

            for (int i = 0; i < stepar.Length; i++)
            {
                for (int j = 0; j < stepar[i].Length; j++) Console.Write(stepar[i][j] + " ");
                Console.WriteLine();
            }
            //--------------------------------------1e
            var varar = new[] { 1, 1 };
            //--------------------------------------2a
            Console.WriteLine("--------------------------------------2a");
            int[] iar = { 1, 2, 3, 4, 5 };
            //--Stack
                Stack<int> mStack = new Stack<int>(iar);
                mStack.Push(6);
                Console.WriteLine("mStack on Top :" + mStack.Peek());
                while (mStack.Count > 0) Console.WriteLine("mStack picked and cleared next-> :" + mStack.Pop());
                mStack.Push(6);
                mStack.Clear();
                if (mStack.Count == 0) Console.WriteLine("mStack IS EMPTY");
            //--------------------------------------------------------------HW5-1c EXCEPTION
            try { mStack.Pop(); }//to generate exception 
            catch (Exception e)
            { Console.WriteLine("!!!EXCEPTION DEFUALT mStack.Pop() Message : " + e.Message); }
            //--Queue
                Queue<int> mQue = new Queue<int>(iar);
                mQue.Enqueue(6);
                Console.WriteLine("mQue FIRST :" + mQue.Peek());
                while (mQue.Count > 0) Console.WriteLine("mQue next-> :" + mQue.Dequeue());
                mQue.Clear();
                if (mQue.Count == 0) Console.WriteLine("mQue IS EMPTY");

            //--------------------------------------------------------------HW5-1c EXCEPTION
            try { mQue.Dequeue(); }
            catch (Exception e)
            { Console.WriteLine("!!!EXCEPTION DEFUALT mQue.Dequeue() Message : " + e.Message); }

            //--List
            List<int> mList = new List<int> { 1, 2, 3, 4, 5 };
            mList.Add(6);
            Console.WriteLine("mList FIRST :" + mList[0].ToString());
            for (int i = 0; i < mList.Count; i++) Console.WriteLine("mList next-> :" + mList[i].ToString());
            mList.Clear();
            if (mList.Count == 0) Console.WriteLine("mList IS EMPTY");
            //--Dictionary
            Dictionary<int, string> mDict = new Dictionary<int, string>()
            {
                [0] = "zero",
                [1] = "one",
                [2] = "two"
            };
            mDict.Add(3, "three");
            Console.WriteLine("mDict FIRST :" + mDict[1].ToString());
            Console.WriteLine("mDict.Count=" + mDict.Count);
            for (int i = 0; i < mDict.Count; i++) Console.WriteLine("mDict next-> :" + mDict[i].ToString());
            mDict.Clear();
            if (mDict.Count == 0) Console.WriteLine("mDict IS EMPTY");

            //--------------------------------------------------------------HW5-1c EXCEPTION
            try { Console.WriteLine(mDict[3].ToString()); }
            catch (Exception e)
            { Console.WriteLine("!!!EXCEPTION DEFUALT mDict[3].ToString() Message : " + e.Message); }
            //--------------------------------------2b
            Console.WriteLine("--------------------------------------2b");
            List<List<int>> m2list = new List<List<int>>();
            m2list.Add(new List<int> { 1, 1, 1 });
            m2list.Add(new List<int> { 2, 2, 2 });
            m2list.Add(new List<int> { 3, 3, 3 });

            //--------------------------------------------------------------HW5-1c
            try
            {
                for (int i = 0; i < m2list.Count; i++)
                {
                    for (int j = 0; j < m2list[i].Count; j++) Console.Write(m2list[i][j].ToString() + " ");
                    Console.WriteLine();
                }
                Console.WriteLine(m2list[10].Count);//to generate exception
            }
            catch (IndexOutOfRangeException e)
            { Console.WriteLine("!!!EXCEPTION IndexOutOfRangeException m2list[10].Count Message : " + e.Message); }
            catch (Exception e)
            { Console.WriteLine("!!!EXCEPTION DEFUALT m2list[10].Count Message : " + e.Message); }
            //--------------------------------------3a
            Console.WriteLine("--------------------------------------3a");
            string[] month_ar = {"January","February","March","April","June","July","August","May","December","September",
                "October","November"};
            int n = 5;
            //---
            var arr = from month in month_ar
                      where month.Length.Equals(n)
                      orderby month
                      select month;
            Console.WriteLine(n + " symbols monthes:");
            foreach (string str in arr) Console.Write(str + " ");
            //---
            arr = from month1 in month_ar
                  where (month1.Contains("January") || month1.Contains("February") || month1.Contains("December")
                        || month1.Contains("June") || month1.Contains("July") || month1.Contains("August"))
                  orderby month1
                  select month1;
            Console.WriteLine("\n Winter and Summer monthes:");
            foreach (string str in arr) Console.Write(str + " ");
            //---
            arr = from month1 in month_ar
                  orderby month1
                  select month1;
            Console.WriteLine("\n Aphabet order monthes:");
            foreach (string str in arr) Console.Write(str + " ");
            //---
            arr = from month in month_ar
                  where (month.IndexOf('u') >= 0 && month.Length >= 4)
                  orderby month
                  select month;
            Console.WriteLine("\n Monthes contain 'u' and length>=4:");
            foreach (string str in arr) Console.Write(str + " ");
            //--------------------------------------3b
            Console.WriteLine("\n--------------------------------------3b");
            months[] mymonths = {
                new months("December", "winter", 9),  new months("January", "winter", 1), new months("February", "winter", 2),
                new months("March", "spring", 3),     new months("April", "spring", 4),   new months("May", "spring", 8),
                new months("June", "summer", 5),      new months("July", "summer", 6),    new months("August", "summer", 7),
                new months("September", "autumn", 10),new months("October", "autumn", 11),new months("November", "autumn", 12)
            };
            month_sum[] mymonth_sum =
            {
                new month_sum("December",119),new month_sum("January",131),new month_sum("February",222),new month_sum("March",233),
                new month_sum("April",324),new month_sum("May",338),new month_sum("June",5),new month_sum("July",6),
                new month_sum("August",7),new month_sum("September",10),new month_sum("October",11),new month_sum("November",12)
            };

            var arr2 = from mon in mymonths
                       where (mon.season == "winter" || mon.season == "summer")
                                && (mon.season.Contains("sum") || mon.season.Contains("win")) //quantifier
                                orderby mon.name ascending
                                select new { name = mon.name, order = mon.order,count=mon.name.Count() };

            Console.WriteLine("\nMonth " + "Order" + "Something else");
            foreach (var arrr in arr2) Console.WriteLine("name=" + arrr.name + " " + "order=" + arrr.order + " " + "count=" + arrr.count);

            var arr3 = from mon in mymonths
                       where (mon.season == "winter" || mon.season == "summer")
                                && (mon.season.Contains("sum") || mon.season.Contains("win")) //quantifier
                       orderby mon.name ascending
                       group mon by mon.season;

            Console.WriteLine("With grouping:\nseason\tname\torder");
            foreach (var arrr in arr3)            
                foreach (var arrr2 in arrr)
                    Console.WriteLine(arrr2.season+ "\t" + arrr2.name + "\t" + arrr2.order);
            //--------------------------------------3c
            Console.WriteLine("--------------------------------------3c");
            var arr4 = from mon in mymonths
                       join sum in mymonth_sum on mon.name equals sum.month_name
                       select new { name = mon.name, amount=sum.amount };
            Console.WriteLine("Name\tAmount");
            foreach (var arrr in arr4) Console.WriteLine(arrr.name + "\t" + arrr.amount);
            //--------------------------------------3d
            Console.WriteLine("--------------------------------------3d");
            List<months> mymonth_list = mymonths.ToList();
            Console.WriteLine("List of monthes:");
            foreach (var lis in mymonth_list) Console.WriteLine(lis.season + "\t" + lis.name);

            //---n length month
            Console.WriteLine($"LIST - {n} length monthes");
            var lis1 = from ls1 in mymonth_list
                       where ls1.name.Length == n
                       select ls1.name;
            foreach (var str in lis1) Console.WriteLine(str + " ");
            //---summer and winter monthes
            var lis2 = from ls1 in mymonth_list
                   where (ls1.name.Equals("January") || ls1.name.Equals("February") || ls1.name.Equals("December")
                        || ls1.name.Equals("June") || ls1.name.Equals("July") || ls1.name.Equals("August"))
                  orderby ls1.name
                   select ls1.name;
            Console.WriteLine("\nLIST -  Winter and Summer monthes:");
            foreach (var str in lis2) Console.WriteLine(str + " ");
            //---alphabet order
            lis2 = from ls1 in mymonth_list
                   orderby ls1.name
                   select ls1.name;
            Console.WriteLine("\nLIST -  Aphabet order monthes:");
            foreach (var str in lis2) Console.WriteLine(str + " ");
            //---
            lis2 = from ls1 in mymonth_list
                   where (ls1.name.ToString().Contains('u') && ls1.name.Length >= 4)
                   orderby ls1.name
                   select ls1.name;
            Console.WriteLine("\nLIST -  Monthes contain 'u' and length>=4:");
            foreach (var str in lis2) Console.WriteLine(str + " ");
            //--------------------------------------3e
            Console.WriteLine("--------------------------------------3e");
            Console.WriteLine("Enum of monthes:");
            foreach (var en in Enum.GetValues(typeof(mymonth_enum))) Console.Write(en+" ");

            //---n length month
            Console.WriteLine($"\nEnum - {n} length monthes:");
            var enar = (mymonth_enum[])Enum.GetValues(typeof(mymonth_enum));
            var enum1 = from en1 in enar
                        where en1.ToString().Length == n
                       select en1;
            foreach (var str in enum1) Console.WriteLine(str + " ");

            //---summer and winter monthes
            enum1 = from en1 in enar
                        where (en1.ToString().Equals("January") || en1.ToString().Equals("February") || en1.ToString().Equals("December")
                             || en1.ToString().Equals("June") || en1.ToString().Equals("July") || en1.ToString().Equals("August"))
                        orderby en1
                        select en1;
            Console.WriteLine("\nEnum -  Winter and Summer monthes:");
            foreach (var str in enum1) Console.WriteLine(str + " ");

            //---alphabet order
            enum1 = from en1 in enar
                    orderby en1
                    select en1;
            Console.WriteLine("\nEnum -  Aphabet order monthes:");
            foreach (var str in enum1) Console.WriteLine(str + " ");
            //---
            enum1 = from en1 in enar
                    where (en1.ToString().Contains('u') && en1.ToString().Length >= 4)
                    orderby en1
                    select en1;
            Console.WriteLine("\nEnum -  Monthes contain 'u' and length>=4:");
            foreach (var str in enum1) Console.WriteLine(str + " ");
        }
    }
}
