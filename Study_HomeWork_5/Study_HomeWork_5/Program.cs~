using System;

namespace Study_HomeWork_5
{
    class excep_demo : Exception
    {
        public excep_demo(string message) : base(message) { }
    }
    public class mydivision// : Exception
    {
        static public double division(double d1, double d2)
        {
            if (d2 == 0) throw new DivideByZeroException();
            if (d2 < 0 || d2 > 10) throw new excep_demo("Input must be from 0 to 10");
            return d1 / d2;
        }
    }

    class MainClass
    {
        public static void Main()
        {
            //---------------------------------------1a
            double n;
         
            try
            {        
                Console.WriteLine("Enter number: ");
                n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("1/n = " + mydivision.division(1, n));
            }
            catch (DivideByZeroException div_ex)
            {
                Console.WriteLine(div_ex.Message);
            }
            catch (excep_demo dem_ex) //custom exception
            {
                Console.WriteLine(dem_ex.Message);
            }
            catch (Exception def_ex)
            {
                Console.WriteLine(def_ex.Message);
            }
        }
    }
}
