using System;

namespace TPExceptions.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException() : base("Para convertir una Fecha a String, la misma no puede tener valor nulo.")
        {

        }

    }
}
