using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blizzard.Api.Data.WoW;

namespace Blizzard.Api.Clients
{
    public interface IWowCommunity : IDisposable
    {
        Task<Achievement> GetAchievementAsync(int id);
        Task<Character> GetCharacterProfileAsync(string realm, string characterName, params string[] fields);
        Task<Guild> GetGuildProfileAsync(string realm, string guildName, params string[] fields);
        Task<Item> GetItemAsync(int id);
        Task<List<RaceDataResource>> GetCharacterRacesAsync();
        Task<List<ItemClass>> GetItemClassesAsync();
        Task<List<RealmStatus>> GetRealmStatusesAsync(params string[] realms);
    }
}