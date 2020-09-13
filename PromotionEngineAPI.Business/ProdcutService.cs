using PromotionEngineAPI.Common;
using PromotionEngineAPI.Common.Constants;
using PromotionEngineAPI.Common.DTO;
using PromotionEngineAPI.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineAPI.Business
{
    public class ProdcutService : IProdcutService
    {
        
        public int GetTotalPrice(SkuIdsDto skuIdsDto)
        {
            int totalPriceofCD = 0;
            int totalPriceofA = (skuIdsDto.ItemA / 3)  * PromotionConstant.PromotionA + (skuIdsDto.ItemA % 3 * PromotionConstant.ProductA);
            int totalPriceofB = (skuIdsDto.ItemB / 2) * PromotionConstant.PromotionB + (skuIdsDto.ItemB % 2 * PromotionConstant.ProductB);
            int totalPriceofC = 0;
            int totalPriceofD = 0;

            if (skuIdsDto.ItemC < skuIdsDto.ItemD)
            {
                totalPriceofCD = skuIdsDto.ItemC * PromotionConstant.PromotionCD;
                totalPriceofD = (skuIdsDto.ItemD - skuIdsDto.ItemC) * PromotionConstant.ProductD;
            }
            else if (skuIdsDto.ItemD < skuIdsDto.ItemC)
            {
                totalPriceofCD = skuIdsDto.ItemD * PromotionConstant.PromotionCD;
                totalPriceofC = (skuIdsDto.ItemC - skuIdsDto.ItemD) * PromotionConstant.ProductC;
            }
            else if (skuIdsDto.ItemD == skuIdsDto.ItemC)
            {
                totalPriceofCD = skuIdsDto.ItemD * PromotionConstant.PromotionCD;
            }

            return  totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD + totalPriceofCD;
        }

        public void GetUnitPrice(Product product)
        {
            product.UnitPrice = product.Item switch
            {
                "A" => 50m,
                "B" => 30m,
                "C" => 20m,
                "D" => 2015m,
                _ => product.UnitPrice
            };
        }
    }
}
