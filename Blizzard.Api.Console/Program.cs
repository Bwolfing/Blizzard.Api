using Blizzard.Api.Clients;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blizzard.Api.Data.Core;
using Blizzard.Api.Data.WoW;
using Newtonsoft.Json;

namespace Blizzard.Api.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GoldValue g = JsonConvert.DeserializeObject<GoldValue>("150");
            System.Console.WriteLine($"{g.ValueInCopper} {g.ValueInSilver} {g.ValueInGold}");
            Task.Run(async () => await GetAchievement(2144).ConfigureAwait(true)).Wait();
        }

        private static async Task GetAchievement(int id)
        {
            using (IWowCommunity wow = new WowCommunity(Region.US, Locale.en_US, string.Empty))
            {
                Achievement a = await wow.GetAchievementAsync(id).ConfigureAwait(true);
                System.Console.WriteLine($"{a?.Title}");
                System.Console.ReadLine();
            }
        }
    }
}