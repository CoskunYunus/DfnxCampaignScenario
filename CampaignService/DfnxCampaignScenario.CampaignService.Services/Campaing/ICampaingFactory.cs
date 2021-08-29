using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DfnxCampaignScenario.CampaignService.Model;
using DfnxCampaignScenario.CatalogService.Model.Basket.Response;

namespace DfnxCampaignScenario.CampaignService.Services.Campaing
{
    public  interface ICampaingFactory
    {

        public BasketPriceModel Calculet();
    }
}
