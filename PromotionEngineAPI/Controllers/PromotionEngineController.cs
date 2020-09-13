using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PromotionEngineAPI.Common;
using PromotionEngineAPI.Common.DTO;
using PromotionEngineAPI.Interface;

namespace PromotionEngineAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PromotionEngineController : ControllerBase
    {
        private Response response;

        private readonly IPromotionBO promotionBO;

        public PromotionEngineController(IPromotionBO promotionBO)
        {
            this.promotionBO = promotionBO;
        }

        /// <summary>
        /// Add Contact Details to Azure SQL Database 
        /// by passing passing Contact Details to be updated
        /// <para name= "Contact"> </para>
        /// </summary>
        /// <returns><ActionResult></returns>
        [HttpPost("CheckoutTotal")]
        public ActionResult<Response> CheckoutTotal(SkuIdsDto item)
        {
            try
            {
                response = promotionBO.GetCheckoutTotal(item);
            }
            catch (Exception ex)
            {
                return new OkObjectResult(response);
            }
            return response;
        }

    }
}
