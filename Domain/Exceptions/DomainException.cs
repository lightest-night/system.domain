using System;
using System.Collections.Generic;
using System.Linq;

namespace LightestNight.System.Domain.Exceptions
{
    public class DomainException : Exception
    {
        /// <summary>
        /// A collection of <see cref="InvariantError" /> objects describing the domain errors thrown
        /// </summary>
        public IEnumerable<InvariantError> Errors { get; } = Enumerable.Empty<InvariantError>();
        
        /// <summary>
        /// Creates an instance of <see cref="DomainException" /> with the given message
        /// </summary>
        /// <param name="message">The message attributed to this Exception</param>
        public DomainException(string message) : base(message){}
        
        /// <summary>
        /// Creates an instance of <see cref="DomainException" /> with the given message and Exception
        /// </summary>
        /// <param name="message">The message attributed to this Exception</param>
        /// <param name="ex">An <see cref="Exception" /> to attribute as the Inner Exception</param>
        public DomainException(string message, Exception ex) : base(message, ex){}

        /// <summary>
        /// Creates an instance of <see cref="DomainException" /> with the given message and collection of <see cref="InvariantError" /> objects
        /// </summary>
        /// <param name="message">The message attributed to this Exception</param>
        /// <param name="errors">The <see cref="InvariantError" /> objects to attribute to this Exception</param>
        public DomainException(string message, params InvariantError[] errors) : this(message)
        {
            Errors = errors;
        }

        /// <summary>
        /// Creates an instance of <see cref="DomainException" /> with the given message, Exception and collection of <see cref="InvariantError" /> objects
        /// </summary>
        /// <param name="message">The message attributed to this Exception</param>
        /// <param name="ex">An <see cref="Exception" /> to attribute as the Inner Exception</param>
        /// <param name="errors">The <see cref="InvariantError" /> objects to attribute to this Exception</param>
        public DomainException(string message, Exception ex, params InvariantError[] errors) : this(message, ex)
        {
            Errors = errors;
        }
    }
}