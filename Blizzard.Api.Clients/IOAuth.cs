using Blizzard.Api.Data.WoW;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blizzard.Api.Clients
{
    public interface IOAuth
    {
        Task<IEnumerable<Character>> WowProfileAsync(string accountAccessToken);
    }
}