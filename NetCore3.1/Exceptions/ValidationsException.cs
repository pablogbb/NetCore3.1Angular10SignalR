using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Exceptions
{
    [Serializable]
    class ValidationsException : Exception
    {
        public ValidationsException()
        {
        }

        public ValidationsException(string message) : base(message)
        {
        }

        public ValidationsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidationsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
