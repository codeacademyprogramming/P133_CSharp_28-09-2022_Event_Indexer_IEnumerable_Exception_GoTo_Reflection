using CustomEvent.Models;
using System;

namespace CustomEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Notify += () => Console.WriteLine("Hello World");
            product.Notify += Test;
            product.Notify -= Test;
            //product.ShowNotify();

            Product product1 = new Product();
            product1.Notify += () => Console.WriteLine("P133 Yatir");
            product1.Notify += Test;
            product1.Notify -= Test;
            //product1.ShowNotify();
        }

        static void Test()
        {

        }
    }
}
