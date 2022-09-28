using System;
using System.Collections.Generic;
using System.Text;

namespace CustomEvent.Models
{
    class Product
    {
        public string Name;
        int _count;
        public event Action Notify
        {
            add
            {
                value.Invoke();
                Console.WriteLine($"{value.Method.Name} {value.Method.IsStatic}");
            }
            remove
            {
                value.Invoke();
                Console.WriteLine($"{value.Method.Name} {value.Method.IsStatic}");
            }
        }
        public void Sell()
        {
            _count--;
        }

        //public void ShowNotify()
        //{
        //    //Notify();
        //}
    }
}
