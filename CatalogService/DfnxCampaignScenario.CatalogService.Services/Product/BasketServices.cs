using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Adaptor;
using DfnxCampaignScenario.CatalogService.Model.Basket.Request;
using DfnxCampaignScenario.CatalogService.Model.Basket.Response;
using DfnxCampaignScenario.CatalogService.Provider.Business;
using DfnxCampaignScenario.CatalogService.Provider.Repo.Base;
using DfnxCampaignScenario.Core;

namespace DfnxCampaignScenario.CatalogService.Services.Product
{
    public class BasketServices : IBasketServices
    {
        private IBasketRepo _basketRepo;

        public BasketServices(IBasketRepo basketRepo)
        {
            _basketRepo = basketRepo;
        }

        public async Task<BaseResponseModel<List<BasketResponseModel>>> GetAll()
        {
            var baskets = _basketRepo.GetAll().Result.ToBasketResponseModel();
            return new BaseResponseModel<List<BasketResponseModel>>
            {
                Result = true,
                Data = baskets,
                StatusCodes = StatusCodes.Ok
            };
        }

        public async Task<BaseResponseModel> AddCart(BasketRequestModel basket)
        {
            var addBasket = basket.ToBasket();
            _basketRepo.NewBasket(addBasket);
            //foreach (var basketItem in addBasket.BasketItems)
            //{
            //    basketItem.Id = addBasket.Id;
            //    _basketRepo.NewBasketItem(basketItem);
            //}
            return new BaseResponseModel
            {
                Result = true,
                StatusCodes = StatusCodes.Ok
            };
        }
    }
}
