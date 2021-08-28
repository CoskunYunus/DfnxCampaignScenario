using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DfnxCampaignScenario.CatalogService.EFBusiness.Context
{
    public class CatalogContext : DbContext, ICatalogContext
    {
        private IConfiguration _configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connection = _configuration.GetSection("connectionString");
            optionsBuilder.UseSqlServer("Server=localhost;Database=dfnx;Trusted_Connection=True;");
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<BasketItem> BasketItem { get; set; }
        public int Save() => SaveChanges();
    }
}
