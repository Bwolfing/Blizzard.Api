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

        protected abstract string RequestUriPrefix { get; }

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

        protected Task<HttpResponseMessage> GetWithApiKeyAndLocaleAsync(string requestUri)
        {
            return GetWithApiKeyAndLocaleAsync(requestUri, new NameValueCollection());
        }

        protected Task<HttpResponseMessage> GetWithApiKeyAndLocaleAsync(string requestUri, NameValueCollection queryStringParams)
        {
            queryStringParams.Add("apikey", _apiKey);
            queryStringParams.Add("locale", _locale.ToString());

            return GetAsync(requestUri + queryStringParams.ToQueryString());
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