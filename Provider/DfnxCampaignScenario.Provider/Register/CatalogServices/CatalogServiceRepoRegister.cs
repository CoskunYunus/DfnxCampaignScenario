using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.EFBusiness.Context;
using DfnxCampaignScenario.CatalogService.EFBusiness.Repo;
using DfnxCampaignScenario.CatalogService.Provider.Repo;
using DfnxCampaignScenario.CatalogService.Provider.Repo.Base;
using Microsoft.Extensions.DependencyInjection;

namespace DfnxCampaignScenario.Provider.Register.CatalogServices
{
    public class CatalogServiceRepoRegister
    {
        public CatalogServiceRepoRegister(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductRepo, ProductRepo>();
            serviceCollection.AddScoped<IBasketRepo, BasketRepo>();
            serviceCollection.AddScoped<ICatalogContext, CatalogContext>();

        }

    }
}
