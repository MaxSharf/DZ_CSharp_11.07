using System;

namespace DZ_CSharp_11._07
{
    class Program
    {
        static void Main(string[] args)
        {

            //Program1();
            Program2();
            //Program3();
            //Program4();
            //Program5();
            //Program6();

            Console.ReadKey(true);

        }

         
        static void PrintSquare(double length , double width, string symbol)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if((i >= 1 && i <=length - 2)&&(j >=1 && j <= width - 2))
                    {
                Console.Write(" ");
                    }
                    else
                    {

                        Console.Write(symbol);
                        //Console.Write("*");
                    }
                   }
             Console.Write("\n\n");
              
            }
        }

        static void Program1()
        {
            Console.WriteLine("Введіть довжину сторони -  ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть ширину сторони -  ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть символ - ");
            string symbol = Console.ReadLine();


            PrintSquare(length, width , symbol);

        }

        static void Program2()
        {
            double x;
            try
            {
                Console.Write("Введiть x=");
                x = Convert.ToDouble(Console.ReadLine());
                Number t = new Number(x);
                t.Print();
                if (t.Correct())
                {
                    double resultprime = Convert.ToDouble(t.Prime());

                    Console.WriteLine("Число є простим", resultprime);

                }
                else Console.WriteLine("Об'єкт iснувати не може");
            }
            catch
            {
                Console.WriteLine("Error!");


            }
        }
    static void Program4()
        {
            WebSite web = new WebSite();
            WebSite web1 = new WebSite();
            web.PrintInfo();
            web1.FillInfo();
            web1.PrintInfo();

        }



        static void Program5()
        {
            Magazine mag = new Magazine();
            mag.PrintInfo();

        }

        static void Program6()
        {
            Shop sh = new Shop();
            sh.PrintInfo();
        }




        //-----------------------------------------------
    }
}
