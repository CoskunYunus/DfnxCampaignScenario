using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CatalogService.Provider.Business;
using DfnxCampaignScenario.CatalogService.Services.Product;
using Microsoft.Extensions.DependencyInjection;

namespace DfnxCampaignScenario.Provider.Register.CatalogServices
{
    public class CatalogServiceRegister
    {

        public CatalogServiceRegister(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductService, ProductServices>();
            serviceCollection.AddScoped<IBasketServices, BasketServices>();

        }

    }
}
