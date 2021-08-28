using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Product.Response;

namespace DfnxCampaignScenario.CatalogService.Model.Basket.Response
{
    public class BasketResponseModel
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public List<BasketItemResponseModel> BasketItems { get; set; }
    }
    public class BasketItemResponseModel
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public ProductResponseModel Product { get; set; }
    }
}
