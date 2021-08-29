using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Entity;

namespace DfnxCampaignScenario.CatalogService.Provider.Repo.Base
{
    public interface IBasketRepo:IBaseRepo
    {
        public Task<List<Basket>> GetAll();
        public Task NewBasket(Basket basket);
        public Task NewBasketItem(BasketItem basketItem);
       public Task<Basket> GetById(int id);
    }
}
