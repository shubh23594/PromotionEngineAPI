﻿using PromotionEngineAPI.Common;
using PromotionEngineAPI.Common.Constants;
using PromotionEngineAPI.Common.DTO;
using PromotionEngineAPI.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PromotionEngineAPI.Business
{
    public class PromotionBO : IPromotionBO
    {
        private readonly IProdcutService prodcutService;

        Response response = new Response
        {
            ResponseMetaData = new ResponseMetaDto()
        };

        public PromotionBO(IProdcutService prodcutService)
        {
            this.prodcutService = prodcutService;
        }
        public Response GetCheckoutTotal(SkuIdsDto skuIdsDto)
        {
            response.TotalAmount = prodcutService.GetTotalPrice(skuIdsDto);
            response.ResponseMetaData.Status = PromotionConstant.Status_Success;
            return response;
        }
    }
}
