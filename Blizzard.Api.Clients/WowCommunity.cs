using System.Collections.Generic;
using System.Threading.Tasks;
using Blizzard.Api.Data.Core;
using Blizzard.Api.Data.WoW;

namespace Blizzard.Api.Clients
{
    public class WowCommunity : ApiClientBase, IWowCommunity
    {
        public WowCommunity(Region region, Locale locale, string apiKey) : base(region, locale, apiKey)
        {
        }

        public Task<Achievement> GetAchievementAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Character> GetCharacterProfileAsync(string realm, string characterName, params string[] fields)
        {
            throw new System.NotImplementedException();
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