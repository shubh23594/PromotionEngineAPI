using Microsoft.AspNetCore.Mvc;
using PromotionEngineAPI.Common.Constants;
using PromotionEngineAPI.Common.DTO;
using PromotionEngineAPI.Interface;
using System;

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
                response.ResponseMetaData.Status = PromotionConstant.Status_Error;
                response.ResponseMetaData.Message = ex.ToString();
            }
            return response;
        }

    }
}
