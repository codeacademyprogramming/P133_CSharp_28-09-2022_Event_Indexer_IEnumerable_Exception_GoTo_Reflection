using CustomIndexer.Collections;
using System;
using System.Collections.Generic;

namespace CustomIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //List<int> intList = new List<int>();
            //intList[0] = 15;
            //int a = intList[0];

            //foreach (var item in intList)
            //{
            //    Console.WriteLine(item);
            //}

            MyCollection<int> myIntCollection = new MyCollection<int>();
            //myIntCollection[0] = 15;
            //int b = myIntCollection[0];
            //Console.WriteLine(b);

            myIntCollection.Add(15);
            myIntCollection.Add(25);
            myIntCollection.Add(35);
            myIntCollection.Add(45);
            myIntCollection.Add(55);
            myIntCollection[0] = 95;


            foreach (int item in myIntCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
