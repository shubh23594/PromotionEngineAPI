using PromotionEngineAPI.Common;
using PromotionEngineAPI.Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineAPI.Interface
{
    public interface IProdcutService
    {
        int GetTotalPrice(SkuIdsDto skuIdsDto);

        int CalculatePromotionB(SkuIdsDto skuIdsDto);

        int CalculatePromotionA(SkuIdsDto skuIdsDto);

        int CalculatePromotionCD(SkuIdsDto skuIdsDto);


    }
}
