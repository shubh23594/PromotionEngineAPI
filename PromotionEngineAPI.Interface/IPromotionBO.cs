using PromotionEngineAPI.Common.DTO;

namespace PromotionEngineAPI.Interface
{
    public interface IPromotionBO
    {
        Response GetCheckoutTotal(SkuIdsDto skuIdsDto);
    }
}
