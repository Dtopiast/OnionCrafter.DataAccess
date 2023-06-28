namespace OnionCrafter.DataAccess.Exceptions
{
    /// <summary>
    /// Exception thrown when attempting to use a DataContext that is not implemented.
    /// </summary>
    [Serializable]
    public class DataAccessContextNotImplementedException : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the DataContextNotImplementedException class with a default error message.
        /// </summary>
        public DataAccessContextNotImplementedException()
        { }

        /// <summary>
        /// Initializes a new instance of the DataContextNotImplementedException class with the specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public DataAccessContextNotImplementedException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataContextNotImplementedException class with the specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception.</param>
        public DataAccessContextNotImplementedException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataContextNotImplementedException class with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected DataAccessContextNotImplementedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}