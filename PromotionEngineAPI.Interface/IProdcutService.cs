using PromotionEngineAPI.Common;
using PromotionEngineAPI.Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineAPI.Interface
{
    public interface IProdcutService
    {
        void GetUnitPrice(Product product);
        int GetTotalPrice(SkuIdsDto skuIdsDto);
    }
}
