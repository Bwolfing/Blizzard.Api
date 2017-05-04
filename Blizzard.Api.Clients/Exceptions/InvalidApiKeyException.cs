using System;

namespace Blizzard.Api.Clients.Exceptions
{
    public class InvalidApiKeyException : Exception
    {
        public InvalidApiKeyException(string apiKey) :
            base($"Invalid api key provided: '{apiKey}'")
        {
        }
    }
}
