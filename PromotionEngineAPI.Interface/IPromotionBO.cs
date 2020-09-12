using PromotionEngineAPI.Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineAPI.Interface
{
    public interface IPromotionBO
    {
        Response GetCheckoutTotal(SkuIdsDto skuIdsDto);
    }
}
