using Blizzard.Api.Clients;
using Blizzard.Api.Data.Core;
using Blizzard.Api.Data.WoW;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Blizzard.Api.Console
{
    public class Program
    {
        private static string ApiKey => string.Empty;

        public static void Main(string[] args)
        {
            GoldValue g = JsonConvert.DeserializeObject<GoldValue>("150");
            System.Console.WriteLine($"{g.ValueInCopper} {g.ValueInSilver} {g.ValueInGold}");
            Task.Run(async () => await GetAchievement(2144).ConfigureAwait(true)).Wait();
            Task.Run(async () => await GetItem(128943).ConfigureAwait(true)).Wait();
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
    }
}