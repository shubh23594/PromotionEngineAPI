using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PromotionEngineAPI.Common.DTO
{
    public class Response
    {
        public string TotalAmount { get; set; }
        public ResponseMetaDto ResponseMetaData { get; set; }
    }
}
