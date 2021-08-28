using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.EFBusiness.Context;
using DfnxCampaignScenario.CatalogService.Model.Entity;
using DfnxCampaignScenario.CatalogService.Provider.Repo.Base;
using Microsoft.EntityFrameworkCore;

namespace DfnxCampaignScenario.CatalogService.EFBusiness.Repo
{
    public class BasketRepo : IBasketRepo
    {
        public readonly ICatalogContext _catalogContext;

        public BasketRepo(ICatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }

        public Task<List<Basket>> GetAll()
        {
            var baskets = _catalogContext.Basket.Include("BasketItems").Include("BasketItems.Product").ToList();
            return Task.FromResult(baskets);
        }

        public Task NewBasket(Basket basket)
        {
            _catalogContext.Basket.Add(basket);
            _catalogContext.Save();
            return Task.CompletedTask;;
        }

        public Task NewBasketItem(BasketItem basketItem)
        {
            _catalogContext.BasketItem.Add(basketItem);
            _catalogContext.Save();
            return Task.CompletedTask;
        }
    }
}
