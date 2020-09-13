using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PromotionEngineAPI.Common.DTO
{
    public class Response
    {
        public int TotalAmount { get; set; }
        public ResponseMetaDto ResponseMetaData { get; set; }
    }
}
