using Blizzard.Api.Clients;
using Blizzard.Api.Data.Core;
using Blizzard.Api.Data.WoW;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Blizzard.Api.Clients.Enums;

namespace Blizzard.Api.Console
{
    public class Program
    {
        private static string ApiKey => string.Empty;

        public static void Main(string[] args)
        {
            Task.Run(async () => await GetCharacter("Wyrmrest Accord", "Haynd").ConfigureAwait(true)).Wait();
        }

        private static async Task GetAchievement(int id)
        {
            using (IWowCommunity wow = new WowCommunity(Region.US, Locale.en_US, ApiKey))
            {
                Achievement a = await wow.GetAchievementAsync(id).ConfigureAwait(false);
                System.Console.WriteLine($"{a?.Title}");
                System.Console.ReadLine();
            }
        }

        private static async Task GetItem(int id)
        {
            using (IWowCommunity wow = new WowCommunity(Region.US, Locale.en_US, ApiKey))
            {
                Item i = await wow.GetItemAsync(id).ConfigureAwait(false);
                System.Console.WriteLine($"{i.Name}");
                System.Console.ReadLine();
            }
        }

        private static async Task GetCharacter(string realm, string name)
        {
            using (IWowCommunity wow = new WowCommunity(Region.US, Locale.en_US, ApiKey))
            {
                var c = await wow.GetCharacterProfileAsync(realm, name, CharacterFields.All).ConfigureAwait(false);
                System.Console.ReadLine();
            }
        }
    }
}