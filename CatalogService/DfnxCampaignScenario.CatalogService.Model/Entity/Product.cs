using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfnxCampaignScenario.CatalogService.Model.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CampaignType Campaign { get; set; }
    }
    public enum CampaignType
    {
        TthreeDiscounts = 1,
        OneFreeItem = 2
    }
}
