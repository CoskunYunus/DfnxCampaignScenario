using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Basket.Response;

namespace DfnxCampaignScenario.CatalogService.Model.Basket.Request
{
    public class BasketRequestModel
    {
        public int MemberId { get; set; }
        public List<BasketItemRequestModel> BasketItems { get; set; }
    }
    public class BasketItemRequestModel
    {
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int ProductSku { get; set; }
    }
}
