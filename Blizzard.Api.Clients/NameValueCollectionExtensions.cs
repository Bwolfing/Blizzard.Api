using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;

namespace Blizzard.Api.Clients
{
    public static class NameValueCollectionExtensions
    {
        public static string ToQueryString(this NameValueCollection collection)
        {
            var queryParams = new List<string>();
            foreach (string queryParam in collection.AllKeys)
            {
                queryParams.AddRange(
                    collection.GetValues(queryParam)
                        .Select(queryValue => $"{WebUtility.UrlEncode(queryParam)}={WebUtility.UrlEncode(queryValue)}")
                );
            }
            return string.Join("&", queryParams);
        }
    }
}