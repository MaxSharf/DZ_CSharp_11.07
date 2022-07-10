using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_CSharp_11._07
{


    public class Number
    {
        double a;
        public Number()
        { }
        public Number(double x)
        { a = x; }
        public void Print()
        {
            Console.WriteLine("a={0}", a);
        }
        public bool Prime()
        {
            bool resultprime = true;

            if (a > 1)
            {
                for (var i = 2u; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        resultprime = false;
                        break;
                    }
                }
            }
            else
            {
                resultprime = false;
            }

            return resultprime;
        }



        public bool Correct()
        {
            bool resultcorrect = false;
            if (a > 0)
                resultcorrect = true;
            return resultcorrect;
        }


    }
    //class Program2

    //{
        //static void Program2_1()
        //{
        //    double x;
        //    try
        //    {
        //        Console.Write("Введiть x=");
        //        x = Convert.ToDouble(Console.ReadLine());
        //        Number t = new Number(x);
        //        t.Print();
        //        if (t.Correct())
        //        {
        //            double resultprime = Convert.ToDouble(t.Prime());

        //            Console.WriteLine("Число є простим", resultprime);

        //        }
        //        else Console.WriteLine("Об'єкт iснувати не може");
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Error!");

        //    }
        //}
   // }
}