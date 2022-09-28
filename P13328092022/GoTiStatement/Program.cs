using System;
using System.Threading;

namespace GoTiStatement
{
    class Program
    {
        static void Main(string[] args)
        {
        //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
        //Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Console.InputEncoding = System.Text.Encoding.UTF8;

        //string name = Console.ReadLine();

        //Console.WriteLine(name);
        //DateTime dateTime1 = new DateTime(2022,10,15);
        //DateTime dateTime2 = new DateTime(2021,05,15);

        //Console.WriteLine((dateTime1-dateTime2));

        //Console.WriteLine(DateTime.Now.ToLongDateString());
        //Console.WriteLine(DateTime.Now.ToShortDateString());

        //Console.WriteLine(DateTime.Now.ToString("dddd"));
        //Console.WriteLine(DateTime.Now.ToString("dddd - $ MMMMM -- yyyyy"));
        //Console.WriteLine($"{DateTime.Now.ToString("dd")} {DateTime.Now.ToString("MMM")}");

        step1:
            Console.WriteLine("Dogum Gununu Daxil Et");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Ayi Daxil Et");
        step2:
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Ili Daxil Et");
            int year = int.Parse(Console.ReadLine());

            int differenceyear = DateTime.Now.Year - year;

            if (differenceyear <= 18)
            {
                Console.WriteLine("Yasini Uygun Deyil. Boyuyende Gelersen");
                goto step1;

            }
            else if(month == 13)
            {
                goto step2;
            }
            else
            {
                goto step3;
            }

        step3:
            Console.WriteLine("Step 3");
        }
    }
}