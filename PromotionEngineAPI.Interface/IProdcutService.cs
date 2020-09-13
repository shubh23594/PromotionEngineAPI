using PromotionEngineAPI.Common.DTO;

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
