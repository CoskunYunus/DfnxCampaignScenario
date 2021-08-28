using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Entity;
using DfnxCampaignScenario.CatalogService.Provider.Repo.Base;

namespace DfnxCampaignScenario.CatalogService.Provider.Repo
{
   public interface IProductRepo: IBaseRepo
    {
        public Task<List<Product>> GetAll();
        public Task NewProduct(Product product);
        public Task UpdateProduct(Product product);
        public Task DeleteBySku(string sku);
        public Task<Product> GetById(int id);
    }
}
