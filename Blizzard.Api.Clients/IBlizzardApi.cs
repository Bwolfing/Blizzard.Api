namespace Blizzard.Api.Clients
{
    public interface IBlizzardApi
    {
        IOAuth OAuth { get; }

        IWowCommunity WoW { get; }
    }
}