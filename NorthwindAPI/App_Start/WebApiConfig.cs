using System.Web.Http;
using NorthwindAPI.Models;
using Microsoft.Restier.EntityFramework;
using Microsoft.Restier.WebApi;
using Microsoft.Restier.WebApi.Batch;


namespace NorthwindAPI
{
    public static class WebApiConfig
    {
        public async static void Register(HttpConfiguration config)
        {
            await config.MapRestierRoute<DbApi<NorthwindContext>>(
                "Northwind",
                "Northwind/v4",
                new RestierBatchHandler(GlobalConfiguration.DefaultServer));
        }
    }
}