using System;
using System.Runtime.Serialization;

namespace DateTimeDemo
{
    public class NoItemAvailableException : Exception
    {
        public NoItemAvailableException()
        {
        }

        public NoItemAvailableException(string message) : base(message)
        {
        }

        public NoItemAvailableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoItemAvailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}