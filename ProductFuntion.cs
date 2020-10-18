using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CNX.TEST
{
    public  class ProductFuntion
    {

        private readonly SalesLTContext _salesLTContext;


        public ProductFuntion (SalesLTContext salesLTContext){
            _salesLTContext = salesLTContext;
        }


        [FunctionName("ProductFuntion")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            String color = req.Query["color"];
            try{
                var products = String.IsNullOrEmpty(color)? await _salesLTContext.Products.ToListAsync()
                                                      : await _salesLTContext.Products.Where(x => x.Color==color).ToListAsync();
            
                if (products.Any()){
                    return new OkObjectResult(products);
                }else{
                    return new NotFoundObjectResult("No products found");
                }
            }catch(Exception ex){
                log.Log(LogLevel.Error, ex.Message);
                return new StatusCodeResult(500);
            }
            
        }
    }
}
