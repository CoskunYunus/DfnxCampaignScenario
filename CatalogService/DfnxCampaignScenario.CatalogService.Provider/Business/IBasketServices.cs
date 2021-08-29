using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Basket.Request;
using DfnxCampaignScenario.CatalogService.Model.Basket.Response;
using DfnxCampaignScenario.CatalogService.Provider.Business.Base;
using DfnxCampaignScenario.CatalogService.Provider.Repo.Base;
using DfnxCampaignScenario.Core;

namespace DfnxCampaignScenario.CatalogService.Provider.Business
{
   public interface IBasketServices:IBaseService
    {
        public Task<BaseResponseModel<List<BasketResponseModel>>> GetAll();
        public Task<BaseResponseModel<BasketResponseModel>> GetBasket(int id);
        public Task<BaseResponseModel> AddCart(BasketRequestModel basket);

    }
}
