using PromotionEngineAPI.Common.DTO;
using PromotionEngineAPI.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PromotionEngineAPI.XunitTest
{
    public class PromotionEngineControllerXunit
    {
        private readonly PromotionEngineController promotionEngineController;
        PromotionEngineControllerXunit() {
           // promotionEngineController = new PromotionEngineController();
        }



        [Fact]
        public async Task ControllerCheckAsync()
        {
            //Arrange
            SkuIdsDto request = new SkuIdsDto
            {
                ItemA = 1,
                ItemB = 2,
                ItemC = 3,
                ItemD = 4
            };

            //Act
          //  var actionResult =  promotionEngineController.CheckoutTotal(request);

            //Assert
          //  var viewResult = Assert.NotNull(actionResult);

        }
    }
}
