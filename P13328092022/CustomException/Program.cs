using CustomException.Exceptions;
using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();

            try
            {

            }
            catch (CustomExceptiontype)
            {

                throw ;
            }
        }

        static int Test()
        {
            if (true)
            {
                //CustomExceptiontype customExceptiontype = new CustomExceptiontype("Custom Exception Type P133", new CustomExceptiontype("Custom Innder Exception"));
                //customExceptiontype.Source = "www.code.edu.az";
                throw new CustomExceptiontype("Custom Exception Type P133");
            }
            return 12;
        }
    }
}
