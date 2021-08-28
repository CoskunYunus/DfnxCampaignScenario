using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Basket.Request;
using DfnxCampaignScenario.CatalogService.Model.Basket.Response;
using DfnxCampaignScenario.CatalogService.Model.Product.Request;
using DfnxCampaignScenario.CatalogService.Model.Product.Response;
using DfnxCampaignScenario.CatalogService.Provider.Business;
using DfnxCampaignScenario.Core;

namespace DfnxCampaignScenario.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IBasketServices  _basketServices;

        public CatalogController(IProductService productService, IBasketServices basketServices)
        {
            _productService = productService;
            _basketServices = basketServices;
        }

        [HttpGet("product")]
        public async Task<BaseResponseModel<List<ProductResponseModel>>> GetProduct()
        {
            var requestData = await _productService.GetAll();
            return requestData;

        }

        [HttpPost("AddProduct")]
        public async Task<BaseResponseModel> AddProduct(ProductRequestModel product)
        {
            var result = await _productService.NewProduct(product);
            return result;
        }

        [HttpPost("UpdateProduct")]
        public async Task<BaseResponseModel> UpdateProduct(ProductRequestModel product)
        {
            var result = await _productService.UpdateProduct(product);
            return result;
        }

        [HttpDelete("DeleteProduct")]
        public async Task<BaseResponseModel> DeleteProduct(string sku)
        {
            var result = await _productService.RemoveProduct(sku);
            return result;
        }

        [HttpGet("Basket")]
        public async Task<BaseResponseModel<List<BasketResponseModel>>> GetBasket()
        {
            return await _basketServices.GetAll();
        }
        [HttpPost("AddCart")]
        public async Task<BaseResponseModel> AddCart(BasketRequestModel requestModel)
        {
            return await _basketServices.AddCart(requestModel);
        }
    }
}
