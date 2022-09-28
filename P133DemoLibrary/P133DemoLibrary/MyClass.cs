using System;
using System.Collections.Generic;
using System.Text;

namespace P133DemoLibrary
{
    public class MyClass
    {
        static int _count;
        public string Name;
        byte _age;
        public string SurName { get; set; }

        public MyClass()
        {

        }

        public MyClass(string name)
        {

        }

        public string ShowInfo(string name)
        {
            return $"P133 Hello World {name}";
        }
    }
}
