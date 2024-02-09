using NLW_LEILAO.API.Contracts;
using NLW_LEILAO.API.Entities;

namespace NLW_LEILAO.API.Repositories.DataAccess
{
    public class OfferRepository : IOfferRepository
    {
        private readonly NlwLeilaoDbContext _dbContext;
        public OfferRepository(NlwLeilaoDbContext dbContext) => _dbContext = dbContext;
        public void Add(Offer offer)
        {
            _dbContext.Offers.Add(offer);

            _dbContext.SaveChanges();
        }
    }
}
