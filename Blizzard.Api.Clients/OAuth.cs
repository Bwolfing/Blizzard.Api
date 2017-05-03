using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Blizzard.Api.Data.Core;
using Blizzard.Api.Data.WoW;

namespace Blizzard.Api.Clients
{
    public class OAuth : ApiClientBase, IOAuth
    {
        protected override string RequestUriPrefix => null;

        public OAuth(Region region, Locale locale, string apiKey) : base(region, locale, apiKey)
        {
        }

        public async Task<IEnumerable<Character>> WowProfileAsync(string accountAccessToken)
        {
            var response = await GetAsync($"wow/user/characters?access_token={accountAccessToken}").ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                // TODO: Determine failure codes if possible here
                throw new Exception("Failed to retrieve characters");
            }

            return await ConvertResponseToObject<IEnumerable<Character>>(response);
        }
    }
}