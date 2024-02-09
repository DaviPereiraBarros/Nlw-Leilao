using NLW_LEILAO.API.Entities;

namespace NLW_LEILAO.API.Contracts
{
    public interface IOfferRepository
    {
        void Add(Offer offer);
    }
}
