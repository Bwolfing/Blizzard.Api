using System;

namespace Blizzard.Api.Clients
{
    public interface IBlizzardApi : IDisposable
    {
        IOAuth OAuth { get; }

        IWowCommunity WoW { get; }
    }
}