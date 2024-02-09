using NLW_LEILAO.API.Contracts;
using NLW_LEILAO.API.Entities;


namespace NLW_LEILAO.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        private readonly IAuctionRepository _repository;
        public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;
        public Auction? Execute() => _repository.GetCurrent();
    
    }
}
