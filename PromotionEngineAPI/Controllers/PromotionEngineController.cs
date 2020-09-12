using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PromotionEngineAPI.Common.DTO;

namespace PromotionEngineAPI.Controllers
{
    [Route("[controller]")]
    public class PromotionEngineController : ControllerBase
    {
        Response response = new Response
        {
            ResponseMetaData = new ResponseMetaDto()
        };

        public PromotionEngineController()
        {
        }

        /// <summary>
        /// Add Contact Details to Azure SQL Database 
        /// by passing passing Contact Details to be updated
        /// <para name= "Contact"> </para>
        /// </summary>
        /// <returns><ActionResult></returns>
        [HttpPost]
        [Route("CheckoutTotal")]
        public ActionResult<Response> CheckoutTotal([FromBody] SkuIdsDto item)
        {
            try
            {
            }
            catch (Exception ex)
            {
                return new OkObjectResult(response);
            }
            return response;
        }

    }
}
