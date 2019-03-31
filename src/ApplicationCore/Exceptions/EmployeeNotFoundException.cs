using System;

namespace ApplicationCore.Exceptions
{

    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException(int id) : base($"No Employee found with id {id}")
        {
        }

        protected EmployeeNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public EmployeeNotFoundException(string message) : base(message)
        {
        }

        public EmployeeNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
