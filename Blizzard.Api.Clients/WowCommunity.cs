using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Blizzard.Api.Clients.Exceptions;
using Blizzard.Api.Data.Core;
using Blizzard.Api.Data.WoW;

namespace Blizzard.Api.Clients
{
    public class WowCommunity : ApiClientBase, IWowCommunity
    {
        protected override string RequestUriPrefix => "wow";

        public WowCommunity(Region region, Locale locale, string apiKey) : base(region, locale, apiKey)
        {
        }

        public async Task<Achievement> GetAchievementAsync(int id)
        {
            var response = await GetWithApiKeyAndLocaleAsync($"achievement/{id}").ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return await ConvertResponseToObject<Achievement>(response).ConfigureAwait(false);
            }

            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    throw new KeyNotFoundException($"Could not find an achievement with id '{id}'");
                default:
                    response.EnsureSuccessStatusCode(); // throws an exception since it failed
                    return null; // EnsureSuccessStatus code doesn't "guarantee" a throw, need a return
            }
        }

        public async Task<Character> GetCharacterProfileAsync(string realm, string characterName, params string[] fields)
        {
            var queryParams = new NameValueCollection();
            if (fields != null && fields.Length > 0)
            {
                queryParams.Add("fields", string.Join(",", fields));
            }
            var response = await GetWithApiKeyAndLocaleAsync($"character/{realm}/{characterName}", queryParams)
                .ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return await ConvertResponseToObject<Character>(response);
            }

            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    throw new KeyNotFoundException($"Could not find a character named '{characterName}' on realm '{realm}'");
                default:
                    response.EnsureSuccessStatusCode();
                    return null;
            }
        }

        public Task<Guild> GetGuildProfileAsync(string realm, string guildName, params string[] fields)
        {
            throw new System.NotImplementedException();
        }

        public Task<Item> GetItemAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<RaceDataResource>> GetCharacterRacesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ItemClass>> GetItemClassesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<RealmStatus>> GetRealmStatusesAsync(params string[] realms)
        {
            throw new System.NotImplementedException();
        }
    }
}