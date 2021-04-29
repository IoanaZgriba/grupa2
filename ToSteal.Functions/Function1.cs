using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ToSteal.DTO.Models;
using WebApplication3.Models;
using Camin = WebApplication3.Models.Camin;

namespace ToSteal.Functions
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

   //         int nr_camere = System.Int32.Parse(req.Query["NrCamere"]);
   //         string Adresa = req.Query["Adresa"].ToString();

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            int nr_camere =  data?.NrCamere ;
            string Adresa = data?.Adresa ;

            if (!string.IsNullOrEmpty(Adresa))
            {
                using (uvtdemosdbContext dbLink = new uvtdemosdbContext())
                {
                    dbLink.Camin.Add(new Camin
                    {
                        IdCamin = 5,
                        IdTaxa = 2,
                        Adresa = Adresa,
                        NrCamere = nr_camere

                    });
                   
                    await dbLink.SaveChangesAsync();
                }
            }

                string responseMessage = string.IsNullOrEmpty(Adresa)
                    ? "This HTTP triggered function executed successfully. Scrie o adresa"
                    : $"Hello, {nr_camere}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }
    }
}

