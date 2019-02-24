using System;

namespace CalculateOneMove.Helpers
{
    public class DivideNullException : Exception
    {
         private readonly string _message;
        public string Message { get { return _message; } }

        public DivideNullException()
        {
            _message = "Деление на ноль.";
        }
    }
}