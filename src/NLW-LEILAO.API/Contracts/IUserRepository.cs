using NLW_LEILAO.API.Entities;

namespace NLW_LEILAO.API.Contracts
{
    public interface IUserRepository
    {
       bool ExistUserWithEmail(string email);
       User GetUserByEmail(string email);
    }
}
