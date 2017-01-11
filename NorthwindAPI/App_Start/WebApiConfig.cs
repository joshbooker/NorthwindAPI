using System.Web.Http;
using NorthwindAPI.Models;
using Microsoft.Restier.EntityFramework;
using Microsoft.Restier.WebApi;
using Microsoft.Restier.WebApi.Batch;
using System.Web.Http.Cors;

namespace NorthwindAPI
{
    public static class WebApiConfig
    {
        public async static void Register(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute("http://localhost:5000", "*", "*");
            cors.SupportsCredentials = true;
            config.EnableCors(cors);
            await config.MapRestierRoute<DbApi<NorthwindContext>>(
                "Northwind",
                "Northwind/v4",
                new RestierBatchHandler(GlobalConfiguration.DefaultServer));
        }
    }
}