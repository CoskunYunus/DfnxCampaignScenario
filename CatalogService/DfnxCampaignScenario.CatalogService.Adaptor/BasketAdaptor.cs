using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Basket.Request;
using DfnxCampaignScenario.CatalogService.Model.Basket.Response;
using DfnxCampaignScenario.CatalogService.Model.Entity;

namespace DfnxCampaignScenario.CatalogService.Adaptor
{
    public static class BasketAdaptor
    {
        public static List<BasketResponseModel> ToBasketResponseModel(this List<Basket> baskets)
        {
            return baskets.Select(c => c.ToBasketResponseModel()).ToList();
        }
        public static BasketResponseModel ToBasketResponseModel(this Basket basket)
        {
            return new BasketResponseModel
            {
                Id = basket.Id,
                MemberId = basket.MemberId,
                BasketItems = basket.BasketItems?.Select(b => new BasketItemResponseModel
                {
                    Id = b.Id,
                    BasketId = b.BasketId,
                    ProductId = b.ProductId,
                    Product = b.Product?.ToProductResponseModel(),
                    Quantity = b.Quantity
                }).ToList()

            };
        }

        public static Basket ToBasket(this BasketRequestModel requestModel)
        {
            var result = new Basket
            {
                MemberId = requestModel.MemberId,
                BasketItems = requestModel.BasketItems.Select(b=> new BasketItem
                {
                    ProductId = b.ProductId,
                    Quantity = b.Quantity,
                }).ToList()
            };
            return result;
        }
    }
}
