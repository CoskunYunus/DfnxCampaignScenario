using System.Collections.Generic;

namespace DfnxCampaignScenario.CampaignService.Model
{
    public class BasketPriceModel
    {
        public int MemberId { get; set; }
        public decimal TotalPrice { get; set; }
        public List<BasketItem> Items { get; set; }
    }

    public class BasketItem
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public ProductModel Product { get; set; }
    }

    public class ProductModel
    {
        public string Slug { get; set; }
        public string Sku { get; set; }
        public decimal Price { get; set; }
        public decimal SalesPrice { get; set; }
    }
}
