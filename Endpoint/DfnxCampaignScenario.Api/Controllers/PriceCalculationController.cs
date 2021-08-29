using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DfnxCampaignScenario.CampaignService.Model;
using DfnxCampaignScenario.CampaignService.Provider;
using DfnxCampaignScenario.CatalogService.Provider.Business;
using DfnxCampaignScenario.Core;

namespace DfnxCampaignScenario.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PriceCalculationController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IBasketServices _basketServices;
        private readonly IBasketCalculation _basketCalculation;

        
        [HttpGet("BasketPriceCalculation")]
        public async Task<BaseResponseModel<BasketPriceModel>> BasketPriceCalculation(int basketId)
        {
            var basket =await _basketServices.GetBasket(basketId);
            var resultCalculation =await _basketCalculation.CalculationBasketPricing(basket.Data);
            return resultCalculation;
        }
    }
}
