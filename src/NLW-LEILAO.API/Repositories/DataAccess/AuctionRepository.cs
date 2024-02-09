using Microsoft.EntityFrameworkCore;
using NLW_LEILAO.API.Contracts;
using NLW_LEILAO.API.Entities;

namespace NLW_LEILAO.API.Repositories.DataAccess
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly NlwLeilaoDbContext _dbContext;
        public AuctionRepository(NlwLeilaoDbContext dbContext) => _dbContext = dbContext;

        public Auction? GetCurrent() 
        {
            var today = DateTime.Now;

            return _dbContext
               .Auctions
               .Include(auction => auction.Items)
               .FirstOrDefault(auction => today >= auction.Starts);
        }
    }
}
