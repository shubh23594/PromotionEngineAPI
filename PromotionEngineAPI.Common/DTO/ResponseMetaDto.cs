using System.Runtime.Serialization;

namespace PromotionEngineAPI.Common.DTO
{
    public class ResponseMetaDto
    {
        public string Status
        {
            get;
            set;
        }

        [DataMember(EmitDefaultValue = false)]
        public string Message
        {
            get;
            set;
        }
    }
}
