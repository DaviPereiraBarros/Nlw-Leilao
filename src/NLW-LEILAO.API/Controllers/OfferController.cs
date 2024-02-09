using Microsoft.AspNetCore.Mvc;
using NLW_LEILAO.API.Comunication.Request;
using NLW_LEILAO.API.Filters;
using NLW_LEILAO.API.UseCases.Offers.CreateOffer;

namespace NLW_LEILAO.API.Controllers
{
    [ServiceFilter(typeof(AuthenticationUserAttribute))]
    [Route("[controller]")]
    public class OfferController : NlwLeilaoBaseController
    {
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreateOffer(
            [FromRoute] int itemId, 
            [FromBody]RequestCreateOfferJson request,
            [FromServices] CreateOfferUseCase useCase)
        {
          var id = useCase.Execute(itemId, request);
                    
            return Created(string.Empty, id);
        }

    }
}
 