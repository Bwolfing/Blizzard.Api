using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
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
            var response = await GetWithApiKeyAndLocaleAsync($"achievement/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new NotImplementedException();
            }

            return await ConvertResponseToObject<Achievement>(response);
        }

        public async Task<Character> GetCharacterProfileAsync(string realm, string characterName, params string[] fields)
        {
            var queryParams = new NameValueCollection();
            if (fields != null && fields.Length > 0)
            {
                foreach (string characterField in fields)
                {
                    queryParams.Add("fields", characterField);
                }
            }
            var response = await GetWithApiKeyAndLocaleAsync($"character/{realm}/{characterName}", queryParams)
                .ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                throw new NotImplementedException();
            }

            return await ConvertResponseToObject<Character>(response);
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