using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Blizzard.Api.Data.Core;

namespace Blizzard.Api.Clients
{
    public abstract class ApiClientBase : HttpClient
    {
        private const string BaseAddressMissingRegion = "https://{0}.api.battle.net/";

        // TODO: Use JsonSerializerSettings.ContractResolver to handle
        // property name casing resolution; http://www.newtonsoft.com/json/help/html/NamingStrategyCamelCase.htm
        protected Region Region { get; }
        protected Locale Locale { get; }

        private string ApiBaseAddress => string.Format(BaseAddressMissingRegion, Region.ToString().ToLower());

        protected ApiClientBase(Region region, Locale locale)
        {
            Region = region;
            Locale = locale;

            BaseAddress = new Uri(ApiBaseAddress);

            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}