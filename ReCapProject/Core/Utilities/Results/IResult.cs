using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //voidler için
    public interface IResult
    {
        //getterler okumak için setterler yazmak için
        bool Success { get; }
        string Message { get; }
    }
}