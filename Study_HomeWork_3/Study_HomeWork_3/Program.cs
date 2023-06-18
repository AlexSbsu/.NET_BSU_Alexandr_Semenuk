using System;
using System.Collections.Generic;
using System.Linq;

namespace Study_HomeWork_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
//--------------------------------------1a
            int[,] ar = new int[,] { {1,1,1 },{2,2,2 } };
            for(int i=0; i< ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++) Console.Write(ar[i, j] + " ");
                Console.WriteLine();
            }
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
            for (int i = 0; i < ar1.Length; i++) Console.Write(ar2[i]);
            if (ar1.Equals(ar2)) Console.WriteLine("\n ar1 Equal to ar2");
            else Console.WriteLine("\n ar1 NON Equal to ar2");
            //--------------------------------------1c
            string[] sar = { "!string1!" , " string2 ", " @string3@ " };
            foreach (string s in sar) Console.Write(s);
            Console.WriteLine("\nlength = " + sar.Length);

            Console.WriteLine("Enter element to change(1-3):");
            int el = int.Parse(Console.ReadLine());
            if (el < 1 || el > 3)
            {
                Console.WriteLine("value must be 1-3");
                return;
            }
            Console.WriteLine("Enter replacement string: ");
            sar[el-1] = Console.ReadLine();
            foreach (string s in sar) Console.Write(s);
            Console.WriteLine();
            //--------------------------------------1d
            double[][] stepar = new double[][]
            {
                new double[] {1,1},
                new double[] { 2,2,2},
                new double[] { 3,3,3}            
            };

            for(int i=0; i<stepar.Length; i++)
            {
                for (int j = 0; j < stepar[i].Length; j++) Console.Write(stepar[i][j]+ " ");
                Console.WriteLine();
            }
            //--------------------------------------2a
            int[] iar = { 1, 2, 3, 4, 5 };
            Stack<int> mStack = new Stack<int>(iar);
            mStack.Push(6);
            Console.WriteLine("mStack on Top :" + mStack.Peek());
            while(mStack.Count>0) Console.WriteLine("mStack picked and cleared next-> :" + mStack.Pop());
            mStack.Push(6);
            mStack.Clear();
            if (mStack.Count == 0) Console.WriteLine("mStack IS EMPTY");
            //--Queue
            Queue<int> mQue = new Queue<int>(iar);
            mQue.Enqueue(6);
            Console.WriteLine("mQue FIRST :" + mQue.Peek());
            while (mQue.Count > 0) Console.WriteLine("mQue next-> :" + mQue.Dequeue());
            mQue.Clear();
            if (mQue.Count == 0) Console.WriteLine("mQue IS EMPTY");
            //--List
            List<int> mList = new List<int> { 1, 2, 3, 4, 5 };
            mList.Add(6);
            Console.WriteLine("mList FIRST :" + mList[0].ToString());
            for(int i = 0; i<mList.Count; i++) Console.WriteLine("mList next-> :" + mList[i].ToString());
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
            //--------------------------------------2b
            List<List<int>> m2list = new List<List<int>>();
            m2list.Add(new List<int> {1,1,1});
            m2list.Add(new List<int> {2,2,2});
            m2list.Add(new List<int> {3,3,3});

            for(int i=0; i<m2list.Count; i++)
            {
                for (int j = 0; j < m2list[i].Count; j++) Console.Write(m2list[i][j].ToString() + " ");
                Console.WriteLine();
            }
            //--------------------------------------3a
            string[] month_ar = {"January","February","March","April","June","July","August","May","December","September",
                "October","November"};
            var sum_wint =  new string[] { "January", "February", "June", "July", "August" };
            int n = 5;
            //---
            var arr = from month in month_ar 
                                    where month.Length.Equals(n)
                                    orderby month
                                    select month;
            Console.WriteLine(n+" symbols monthes:");
            foreach (string str in arr) Console.Write(str+" ");
            //---
            arr = from month1 in month_ar
                                  where (month1.Contains("January")||month1.Contains("February") || month1.Contains("December")
                                        ||month1.Contains("June") || month1.Contains("July") || month1.Contains("August"))
                                  orderby month1
                                  select month1;
            Console.WriteLine("\n Winter and Summer monthes:");
            foreach (string str in arr) Console.Write(str + " ");
            //---
            arr = from month1 in month_ar
                      //where month1.Contains(a=>a)
                  orderby month1
                  select month1;
            Console.WriteLine("\n Aphabet order monthes:");
            foreach (string str in arr) Console.Write(str + " ");
            //---
            arr = from month1 in month_ar
                    where (month1.IndexOf('u')>=0 && month1.Length>=4)
                    orderby month1
                    select month1;
            Console.WriteLine("\n Monthes contain 'u' and length>=4:");
            foreach (string str in arr) Console.Write(str + " ");
            //--------------------------------------3b

            //--------------------------------------3c

            //--------------------------------------3d

            //--------------------------------------3e

        }
    }
}
