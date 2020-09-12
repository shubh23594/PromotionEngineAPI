using PromotionEngineAPI.Common.DTO;
using PromotionEngineAPI.Interface;
using System;
using System.Threading.Tasks;

namespace PromotionEngineAPI.Business
{
    public class PromotionBO : IPromotionBO
    {
        Response response = new Response
        {
            TotalAmount = "100",
            ResponseMetaData = new ResponseMetaDto()
            {
                Status = "S"
            }
        };
        public Response GetCheckoutTotal(SkuIdsDto skuIdsDto)
        {
            return response;
        }
    }
}
