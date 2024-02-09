using Microsoft.EntityFrameworkCore;
using NLW_LEILAO.API.Entities;

namespace NLW_LEILAO.API.Repositories
{
    public class NlwLeilaoDbContext : DbContext
    {
        public NlwLeilaoDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; } 
        public DbSet<Offer> Offers { get; set; }
    }
}
