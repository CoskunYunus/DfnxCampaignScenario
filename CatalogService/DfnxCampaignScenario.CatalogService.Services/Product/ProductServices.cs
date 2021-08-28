using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Adaptor;
using DfnxCampaignScenario.CatalogService.Model.Product.Request;
using DfnxCampaignScenario.CatalogService.Model.Product.Response;
using DfnxCampaignScenario.CatalogService.Provider.Business;
using DfnxCampaignScenario.CatalogService.Provider.Repo;
using DfnxCampaignScenario.Core;

namespace DfnxCampaignScenario.CatalogService.Services.Product
{
    public class ProductServices : IProductService
    {
        private IProductRepo _productRepo;

        public ProductServices(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<BaseResponseModel<List<ProductResponseModel>>> GetAll()
        {
            /*
                 ....
             */

            var data = _productRepo.GetAll().Result.ToProductResponseModel();
            return new BaseResponseModel<List<ProductResponseModel>>
            {
                Result = true,
                Data = data,
                StatusCodes = StatusCodes.Ok
            };
        }

        public async Task<BaseResponseModel> NewProduct(ProductRequestModel product)
        {
            /*
                 ....
             */

            _productRepo.NewProduct(product.ToProduct());
            return new BaseResponseModel
            {
                Result = true,
                StatusCodes = StatusCodes.Ok
            };
        }

        public async Task<BaseResponseModel> UpdateProduct(ProductRequestModel product)
        {
            /*
                 ....
             */
            var data = await _productRepo.GetById(product.Id);
            _productRepo.UpdateProduct(product.ToProduct(data));

            return new BaseResponseModel
            {
                Result = true,
                StatusCodes = StatusCodes.Ok
            };
        }

        public async Task<BaseResponseModel> RemoveProduct(string sku)
        {
            /*
               ....
           */
            _productRepo.DeleteBySku(sku);
            return new BaseResponseModel
            {
                Result = true,
                StatusCodes = StatusCodes.Ok
            };
        }
    }
}
