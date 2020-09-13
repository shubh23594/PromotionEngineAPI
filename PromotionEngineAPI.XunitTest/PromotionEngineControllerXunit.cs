using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PromotionEngineAPI.Business;
using PromotionEngineAPI.Common.DTO;
using PromotionEngineAPI.Controllers;
using PromotionEngineAPI.Interface;
using Xunit;

namespace PromotionEngineAPI.XunitTest
{
    public class PromotionEngineControllerXunit
    {
        private readonly PromotionBO promotionBO;  
        private readonly ProdcutService prodcutService ;  
        private  PromotionEngineController promotionEngineController;
        public PromotionEngineControllerXunit() {
            promotionBO = new PromotionBO(prodcutService);
            promotionEngineController = new PromotionEngineController(promotionBO);
        }



        [Fact]
        public void CheckBOLayer()
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
            var moc = new Mock<IProdcutService>();
            moc.Setup(m => m.CalculatePromotionA(It.IsAny<SkuIdsDto>())).Returns(100);
            moc.Setup(m => m.CalculatePromotionB(It.IsAny<SkuIdsDto>())).Returns(100);
            moc.Setup(m => m.CalculatePromotionCD(It.IsAny<SkuIdsDto>())).Returns(100);
            moc.Setup(m => m.GetTotalPrice(It.IsAny<SkuIdsDto>())).Returns(100);
            var proBo = new PromotionBO(moc.Object);
            Response Resp = proBo.GetCheckoutTotal(request);

            //Assert
            Assert.Equal(100, Resp.TotalAmount);

        }

        [Fact]
        public void checkContoller()
        {
            //Arrange
            SkuIdsDto request = new SkuIdsDto
            {
                ItemA = 1,
                ItemB = 2,
                ItemC = 3,
                ItemD = 4
            };

            Response response = new Response()
            {
                TotalAmount = 200,
                ResponseMetaData = new ResponseMetaDto()
                {
                    Status = "S"
                }
            };

            var moc = new Mock<IPromotionBO>();
            moc.Setup(m => m.GetCheckoutTotal(It.IsAny<SkuIdsDto>())).Returns(response);

            promotionEngineController = new PromotionEngineController(moc.Object)
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext()
                }
            };

            //Act
            var response1 = promotionEngineController.CheckoutTotal(request);

            //Assert
            Assert.NotNull(response1);
        }
    }
}
