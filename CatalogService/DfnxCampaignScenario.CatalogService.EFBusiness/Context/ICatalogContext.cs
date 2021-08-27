using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace DfnxCampaignScenario.CatalogService.EFBusiness.Context
{
    public interface ICatalogContext
    {
        public DbSet<Product> Product { get; set; }

    }
}
