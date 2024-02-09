using Microsoft.AspNetCore.Mvc;
using NLW_LEILAO.API.Entities;
using NLW_LEILAO.API.UseCases.Auctions.GetCurrent;

namespace NLW_LEILAO.API.Controllers
{
    [Route("[controller]")]
    public class AuctionController : NlwLeilaoBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
        {

            var result  = useCase.Execute();

            if (result is null)
                return NoContent();

            return Ok(result);
        }
    }
}
