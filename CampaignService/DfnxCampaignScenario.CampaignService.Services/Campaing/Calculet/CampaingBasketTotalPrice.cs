using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CampaignService.Model;
using DfnxCampaignScenario.CatalogService.Model.Basket.Response;

namespace DfnxCampaignScenario.CampaignService.Services.Campaing
{
    public class CampaingBasketTotalPrice : ICampaingFactory
    {
        private BasketResponseModel basket;
        public CampaingBasketTotalPrice(BasketResponseModel model)
        {
            basket = model;
        }

        public BasketPriceModel Calculet()
        {

            //    KAPMAPNYA HESAPLAMASI


            var totalPrice = basket.BasketItems?.Sum(c => c.Quantity * c.Product?.Price);

            var basketItem = new List<BasketItem>();
            if (totalPrice >= 1000)
            {
                var minPrice = basket.BasketItems.Select(c => c.Product.Price).Min();
                foreach (var item in basket.BasketItems)
                {
                    basketItem.Add(new BasketItem
                    {
                        Quantity = item.Quantity,
                        DiscountPrice = item.Product.Price * item.Quantity,
                        Product = null,
                        Price = item.Product.Price * item.Quantity

                    });
                }
            }

            return null;
        }
    }
}
