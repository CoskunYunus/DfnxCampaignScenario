using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CampaignService.Model;
using DfnxCampaignScenario.CatalogService.Model.Basket.Response;
using DfnxCampaignScenario.Core;

namespace DfnxCampaignScenario.CampaignService.Provider
{
    public interface IBasketCalculation
    {
        public Task<BaseResponseModel<BasketPriceModel>> CalculationBasketPricing(BasketResponseModel basket);
    }
}
