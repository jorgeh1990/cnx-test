using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;

namespace CNX.TEST
{
    public  class PeopleFuntion
    {

        private readonly IPeopleService _peopleSerivice;


        public PeopleFuntion (IPeopleService peopleService){
            _peopleSerivice = peopleService;
        }


        [FunctionName("PeopleFuntion")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            try{
                var peopleResponse = await _peopleSerivice.GetPeople();
                if (peopleResponse.People.Any()){
                return new OkObjectResult(peopleResponse.People);
                }else{
                    return new NotFoundObjectResult("No people found");
                }
            }catch(Exception ex){
                log.Log(LogLevel.Error, ex.Message);
                return new StatusCodeResult(500);
            }
            
            
        }
    }
}
