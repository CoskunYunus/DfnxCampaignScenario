using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Product.Request;
using DfnxCampaignScenario.CatalogService.Model.Product.Response;
using DfnxCampaignScenario.CatalogService.Provider.Business.Base;
using DfnxCampaignScenario.Core;

namespace DfnxCampaignScenario.CatalogService.Provider.Business
{
    public  interface  IProductService: IBaseService
    {
        public Task<BaseResponseModel<List<ProductResponseModel>>> GetAll();
        public Task<BaseResponseModel> NewProduct(ProductRequestModel product);
        public Task<BaseResponseModel> UpdateProduct(ProductRequestModel product);
    }
}
