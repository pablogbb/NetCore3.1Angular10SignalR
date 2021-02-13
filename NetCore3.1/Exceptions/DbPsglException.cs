using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    public class DbPsglException : Exception
    {
        public DbPsglException()
        {
        }

        public DbPsglException(string message) : base(message)
        {
        }

        public DbPsglException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbPsglException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
