using System;

namespace LightestNight.System.Domain.Exceptions
{
    public class ConflictException : Exception
    {
        /// <summary>
        /// The key of the object that caused the conflict
        /// </summary>
        public object Key { get; }

        /// <summary>
        /// Creates an instance of <see cref="ConflictException" /> with the given Key
        /// </summary>
        /// <param name="key">The key of the object that caused the conflict</param>
        public ConflictException(object key) : base($"An item with the key: '{key}' already exists.")
        {
            Key = key;
        }
    }
}