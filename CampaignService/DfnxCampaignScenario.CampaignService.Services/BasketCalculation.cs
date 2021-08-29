using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CampaignService.Model;
using DfnxCampaignScenario.CampaignService.Provider;
using DfnxCampaignScenario.CampaignService.Services.Campaing;
using DfnxCampaignScenario.CatalogService.Model.Basket.Response;
using DfnxCampaignScenario.CatalogService.Model.Entity;
using DfnxCampaignScenario.Core;

namespace DfnxCampaignScenario.CampaignService.Services
{
    public class BasketCalculation : IBasketCalculation
    {


        public async Task<BaseResponseModel<BasketPriceModel>> CalculationBasketPricing(BasketResponseModel basket)
        {
            var campaingResuldBasket = new List<BasketPriceModel>();
            // CampaingTthreeDiscounts
            bool? isCampaingTthreeDiscounts =
                basket.BasketItems?.Any(c => c.Product?.Campaign == CampaignType.TthreeDiscounts.ToString());
            if (isCampaingTthreeDiscounts == true)
            {
                ICampaingFactory campaingFactory = new CampaingTthreeDiscounts(basket);
                var resultBasket = campaingFactory.Calculet();
                if (resultBasket != null)
                    campaingResuldBasket.Add(resultBasket);
            }

            // CampaingOneFreeItem
            bool? isCampaingOneFreeItem =
                    basket.BasketItems?.Any(c => c.Product?.Campaign == CampaignType.TthreeDiscounts.ToString());
            if (isCampaingOneFreeItem == true)
            {
                ICampaingFactory campaingFactory = new CampaingOneFreeItem(basket);
                var resultBasket = campaingFactory.Calculet();
                if (resultBasket != null)
                    campaingResuldBasket.Add(resultBasket);
            }

            //CampaingBasketTotalPrice
            ICampaingFactory campaingFactoryB = new CampaingOneFreeItem(basket);
            var resultBasketB = campaingFactoryB.Calculet();
            if (resultBasketB != null)
                campaingResuldBasket.Add(resultBasketB);

            var minTotalPrice = campaingResuldBasket.Select(c => c.TotalPrice).Min();
            var returnBasket = campaingResuldBasket.FirstOrDefault(c => c.TotalPrice == minTotalPrice);

            return new BaseResponseModel<BasketPriceModel>
            {
                Result = true,
                StatusCodes = StatusCodes.Ok,
                Data = returnBasket
            };
        }


    }
}
