using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
