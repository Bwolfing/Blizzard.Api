using Blizzard.Api.Data.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Blizzard.Api.Clients
{
    public abstract class ApiClientBase : HttpClient
    {
        private const string BaseAddressMissingRegion = "https://{0}.api.battle.net/";

        // TODO: Use JsonSerializerSettings.ContractResolver to handle
        // property name casing resolution; http://www.newtonsoft.com/json/help/html/NamingStrategyCamelCase.htm

        private string ApiBaseAddress => string.Format(BaseAddressMissingRegion, _region.ToString().ToLower());
        private readonly string _apiKey;
        private readonly Region _region;
        private readonly Locale _locale;

        protected ApiClientBase(Region region, Locale locale, string apiKey)
        {
            _region = region;
            _locale = locale;
            _apiKey = apiKey;

            BaseAddress = new Uri(ApiBaseAddress);

            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected Task<string> GetStringWithReponseValidationAsync(string requestUri)
        {
            return GetStringWithReponseValidationAsync(requestUri, new NameValueCollection());
        }

        protected async Task<string> GetStringWithReponseValidationAsync(string requestUri, NameValueCollection queryStringParams)
        {
            queryStringParams.Add("apikey", _apiKey);
            queryStringParams.Add("locale", _locale.ToString());

            var response = await GetAsync(requestUri + queryStringParams.ToQueryString());

            return string.Empty;
        }

        protected async Task<T> ConvertResponseToObject<T>(HttpResponseMessage response)
        {
            string jsonStr = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(jsonStr, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            });
        }
    }
}