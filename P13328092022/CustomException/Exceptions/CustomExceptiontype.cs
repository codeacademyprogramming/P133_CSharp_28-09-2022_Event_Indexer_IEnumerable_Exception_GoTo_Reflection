using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException.Exceptions
{
    class CustomExceptiontype : NullReferenceException
    {

        //public override string Source { get => base.Source; set => base.Source = "www.code.edu.az"; }
        public CustomExceptiontype(string msg) : base(msg)
        {

        }

        //public CustomExceptiontype(string msg, CustomExceptiontype customExceptiontype) : base(msg,customExceptiontype)
        //{

        //}
    }
}
