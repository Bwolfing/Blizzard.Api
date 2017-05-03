using Blizzard.Api.Clients;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blizzard.Api.Data.Core;
using Blizzard.Api.Data.WoW;

namespace Blizzard.Api.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
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