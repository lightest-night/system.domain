namespace Domain.Exceptions
{
    public struct InvariantError
    {
        /// <summary>
        /// A message identifying the error
        /// </summary>
        public string ErrorText { get; set; }
        
        /// <summary>
        /// The parameter the error pertains to
        /// </summary>
        public string Parameter { get; set; }

    }
}