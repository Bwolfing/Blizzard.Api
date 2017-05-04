using Blizzard.Api.Data.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Blizzard.Api.Clients.Exceptions;

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

        protected async Task<HttpResponseMessage> GetWithApiKeyAndLocaleAsync(string requestUri, NameValueCollection queryStringParams)
        {
            var response = await GetAsync(RequestUriWithQueryString(requestUri, queryStringParams));

            EnsureResponseIsSuccess(response);

            return response;
        }

        protected Task<T> ConvertResponseTo<T>(HttpResponseMessage response)
        {
            return ConvertResponseTo<T>(response, null);
        }

        protected async Task<T> ConvertResponseTo<T>(HttpResponseMessage response, JsonConverter objectConverter)
        {
            string jsonStr = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };
            if (objectConverter != null)
            {
                serializerSettings.Converters.Add(objectConverter);
            }

            return JsonConvert.DeserializeObject<T>(jsonStr, serializerSettings);
        }

        private string RequestUriWithQueryString(string requestUri, NameValueCollection queryStringParams)
        {
            queryStringParams.Add("apikey", _apiKey);
            queryStringParams.Add("locale", _locale.ToString());

            string requestUriWithQueryString = $"{requestUri}?{queryStringParams.ToQueryString()}";
            if (!string.IsNullOrWhiteSpace(RequestUriPrefix))
            {
                requestUriWithQueryString = $"{RequestUriPrefix}/{requestUriWithQueryString}";
            }
            return requestUriWithQueryString;
        }

        private void EnsureResponseIsSuccess(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                throw new InvalidApiKeyException(_apiKey);
            }
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new KeyNotFoundException();
            }
            response.EnsureSuccessStatusCode();
        }
    }
}