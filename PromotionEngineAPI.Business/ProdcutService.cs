using PromotionEngineAPI.Common.Constants;
using PromotionEngineAPI.Common.DTO;
using PromotionEngineAPI.Interface;

namespace PromotionEngineAPI.Business
{
    public class ProdcutService : IProdcutService
    {
        /// <summary>
        ///Calculating Total Price of Product A, B, C and D
        /// </summary>
        public int GetTotalPrice(SkuIdsDto skuIdsDto)
        {
            int totalPriceofA = CalculatePromotionA(skuIdsDto);             
            int totalPriceofB = CalculatePromotionB(skuIdsDto);
            int totalPriceofCD = CalculatePromotionCD(skuIdsDto);
            
            return  totalPriceofA + totalPriceofB + totalPriceofCD;
        }

        /// <summary>
        ///Calculating Promotion A values
        /// </summary>
        public int CalculatePromotionA(SkuIdsDto skuIdsDto)
        {
            return (skuIdsDto.ItemA / 3) * PromotionConstant.PromotionA + (skuIdsDto.ItemA % 3 * PromotionConstant.ProductA);
        }

        /// <summary>
        ///Calculating Promotion B values
        /// </summary>
        public int CalculatePromotionB(SkuIdsDto skuIdsDto)
        {
            return (skuIdsDto.ItemB / 2) * PromotionConstant.PromotionB + (skuIdsDto.ItemB % 2 * PromotionConstant.ProductB);
        }

        /// <summary>
        ///Calculating Promotion CD values
        /// </summary>
        public int CalculatePromotionCD(SkuIdsDto skuIdsDto)
        {
            int total = 0;
            if (skuIdsDto.ItemC < skuIdsDto.ItemD)
            {
                total = skuIdsDto.ItemC * PromotionConstant.PromotionCD;
                total += (skuIdsDto.ItemD - skuIdsDto.ItemC) * PromotionConstant.ProductD;
            }
            else if (skuIdsDto.ItemD < skuIdsDto.ItemC)
            {
                total = skuIdsDto.ItemD * PromotionConstant.PromotionCD;
                total += (skuIdsDto.ItemC - skuIdsDto.ItemD) * PromotionConstant.ProductC;
            }
            else if (skuIdsDto.ItemD == skuIdsDto.ItemC)
            {
                total = skuIdsDto.ItemD * PromotionConstant.PromotionCD;
            }

            return total;
        }
    }
}
