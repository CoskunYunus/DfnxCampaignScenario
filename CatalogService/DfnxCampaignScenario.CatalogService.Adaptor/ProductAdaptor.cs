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
                /*
                  ....
                 */
            }).ToList();
        }

        public static Product ToProduct(this  ProductRequestModel requestModel)
        {
            return new Product
            {
                /*
                 ....
                 */
            };
        }
    }
}
