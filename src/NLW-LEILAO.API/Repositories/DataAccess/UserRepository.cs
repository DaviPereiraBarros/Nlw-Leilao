using NLW_LEILAO.API.Contracts;
using NLW_LEILAO.API.Entities;

namespace NLW_LEILAO.API.Repositories.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly NlwLeilaoDbContext _dbContext;
        public UserRepository(NlwLeilaoDbContext dbContext) => _dbContext = dbContext;

        public bool ExistUserWithEmail(string email) 
        {
            return _dbContext.Users.Any(user => user.Email.Equals(email));
        }

        public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
    }
}
