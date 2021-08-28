using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Entity;
using DfnxCampaignScenario.CatalogService.Model.Product.Request;
using DfnxCampaignScenario.CatalogService.Model.Product.Response;

namespace DfnxCampaignScenario.CatalogService.Adaptor
{
    public static class ProductAdaptor
    {
        public static List<ProductResponseModel> ToProductResponseModel(this List<Product> product)
        {
            return product.Select(c => new ProductResponseModel
            {
                Campaign = c.Campaign.ToString(),
                Sku = c.Sku,
                Description = c.Description,
                Id = c.Id,
                Price = c.Price,
                Slug = c.Slug,
                Title = c.Title
            }).ToList();
        }
        public static ProductResponseModel ToProductResponseModel(this Product product)
        {
            var result = new ProductResponseModel
            {
                Campaign = product.Campaign.ToString(),
                Sku = product.Sku,
                Description = product.Description,
                Id = product.Id,
                Price = product.Price,
                Slug = product.Slug,
                Title = product.Title
            };
            return result;
        }

        public static Product ToProduct(this ProductRequestModel requestModel)
        {
            return new Product
            {
                Slug = requestModel.Slug,
                Campaign = (CampaignType)requestModel.Campaign,
                Sku = requestModel.Sku,
                Title = requestModel.Title,
                Description = requestModel.Description,
                Id = requestModel.Id,
                Price = requestModel.Price
            };
        }
        public static Product ToProduct(this ProductRequestModel requestModel, Product product)
        {
            product.Slug = requestModel.Slug;
            product.Campaign = (CampaignType)requestModel.Campaign;
            product.Sku = requestModel.Sku;
            product.Title = requestModel.Title;
            product.Description = requestModel.Description;
            product.Price = requestModel.Price;
            return product;
        }
    }
}
