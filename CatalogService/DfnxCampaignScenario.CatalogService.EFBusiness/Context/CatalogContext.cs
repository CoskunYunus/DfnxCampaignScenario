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
   public class CatalogContext: DbContext, ICatalogContext
    {
        private IConfiguration _configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = _configuration.GetSection("connectionString");
            optionsBuilder.UseSqlServer(connection.Value);
        }
        public DbSet<Product> Product { get; set; }
    }
}
