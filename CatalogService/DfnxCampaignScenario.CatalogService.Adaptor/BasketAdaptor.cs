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
            return baskets.Select(c => new BasketResponseModel
            {
                Id = c.Id,
                MemberId = c.MemberId,
                BasketItems = c.BasketItems?.Select(b => new BasketItemResponseModel
                {
                    Id = b.Id,
                    BasketId = b.BasketId,
                    ProductId = b.ProductId,
                    Product = b.Product?.ToProductResponseModel(),
                    Quantity = b.Quantity
                }).ToList()

            }).ToList();
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
