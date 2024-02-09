using NLW_LEILAO.API.Entities;

namespace NLW_LEILAO.API.Contracts
{
    public interface IAuctionRepository
    {
        Auction? GetCurrent();
    }
}
