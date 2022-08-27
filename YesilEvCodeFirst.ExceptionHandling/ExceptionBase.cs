using System;

namespace YesilEvCodeFirst.ExceptionHandling
{
    public class ExceptionBase : Exception
    {
        public ExceptionBase() { }

        public ExceptionBase(string message) : base(message) { }

        public ExceptionBase(string message, Exception innerException) : base(message, innerException) { }
    }
}
