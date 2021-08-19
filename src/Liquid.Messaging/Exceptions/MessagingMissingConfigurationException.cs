﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Liquid.Core.Exceptions;

namespace Liquid.Messaging.Exceptions
{
    /// <summary>
    /// Occurs when a Configuration in settings configuration does not exist.
    /// </summary>
    /// <seealso cref="LiquidException" />
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class MessagingMissingConfigurationException : LiquidException
    {
        ///<inheritdoc/>
        public MessagingMissingConfigurationException(Exception innerException) : base("The messaging configuration is missing. See inner exception for more detail.", innerException)
        {
        }

        ///<inheritdoc/>
        public MessagingMissingConfigurationException(string message) : base(message)
        {
        }
        
        /// <inheritdoc/>
        protected MessagingMissingConfigurationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}