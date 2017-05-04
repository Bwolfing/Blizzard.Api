using Blizzard.Api.Clients.Enums;
using Blizzard.Api.Data.Core;
using Blizzard.Api.Data.WoW;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

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
            try
            {
                var response = await GetWithApiKeyAndLocaleAsync($"achievement/{id}").ConfigureAwait(false);
                return await ConvertResponseToObject<Achievement>(response);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException($"Could not find an achievement with id '{id}'");
            }
        }

        public async Task<Character> GetCharacterProfileAsync(string realm, string characterName, params CharacterFields[] fields)
        {
            var queryParams = SetFieldsQueryStringParam(fields);

            try
            {
                var response = await GetWithApiKeyAndLocaleAsync($"character/{realm}/{characterName}", queryParams).ConfigureAwait(false);
                return await ConvertResponseToObject<Character>(response);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException($"Could not find a character named '{characterName}' on realm '{realm}'");
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

        private NameValueCollection SetFieldsQueryStringParam(CharacterFields[] fields)
        {
            var queryParams = new NameValueCollection();
            if (fields != null && fields.Length > 0)
            {
                if (fields.Contains(CharacterFields.All))
                {
                    queryParams.Add("fields",
                        string.Join(",",
                            Enum.GetNames(typeof(CharacterFields))
                                .Where(f => f != CharacterFields.All.ToString())
                                .Select(f => f.ToLower())
                        )
                    );
                }
                else
                {
                    queryParams.Add("fields",
                        string.Join(",", fields.Select(f => f.ToString().ToLower()))
                    );
                }
            }
            return queryParams;
        }
    }
}