using System;
using System.Collections.Generic;

namespace YesilEvCodeFirst.ExceptionHandling
{
    public class ModelNotValidException : ExceptionBase
    {
        public List<string> ValidationMessages { get; set; }
        public ModelNotValidException(List<string> validationMessages)
        {
            ValidationMessages = validationMessages;
        }

        public ModelNotValidException(List<string> validationMessages, string message) : base(message)
        {
            ValidationMessages = ValidationMessages;
        }

        public ModelNotValidException(List<string> validationMessages, string message, Exception innerException) : base(message, innerException)
        {
            ValidationMessages = validationMessages;
        }
    }
}
