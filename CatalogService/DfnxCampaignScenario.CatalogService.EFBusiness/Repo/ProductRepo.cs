using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.EFBusiness.Context;
using DfnxCampaignScenario.CatalogService.Model.Entity;
using DfnxCampaignScenario.CatalogService.Provider.Repo;

namespace DfnxCampaignScenario.CatalogService.EFBusiness.Repo
{
    public class ProductRepo : IProductRepo
    {
        public readonly ICatalogContext _catalogContext;

        public ProductRepo(ICatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }

        public Task<List<Product>> GetAll()
        {
            var data = _catalogContext.Product.ToList(); // TODO Pagination, filtering vb
            return Task.FromResult(data);
        }

        public Task NewProduct(Product product)
        {
            var data = _catalogContext.Product.Add(product); // TODO Validation
            _catalogContext.Save();
            return Task.CompletedTask;
        }

        public Task UpdateProduct(Product product)
        {
            var data = _catalogContext.Product.Update(product); // TODO Validation
            _catalogContext.Save();

            return Task.CompletedTask;
        }

        public Task DeleteBySku(string sku)
        {
            var product = _catalogContext.Product.FirstOrDefault(c => c.Sku == sku);
            if (product == null)
                return Task.FromException(null);
            _catalogContext.Product.Remove(product); // TODO Validation
            _catalogContext.Save();
            return Task.CompletedTask;
        }

        public Task<Product> GetById(int id)
        {
            var product = _catalogContext.Product.Find(id);
            return Task.FromResult(product);
        }
    }
}
