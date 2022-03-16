using ExternalService.Model.Accessory;
using Newtonsoft.Json;
using Shared.Enums;
using System.Collections.Generic;

namespace ExternalService.Model.Requests
{
    public class RegulaServiceRequest : IExternalServiceRequest
    {
        [JsonProperty(PropertyName = "processParam")]
        public RegulaProcessParam ProcessParam { get; private set; }


        [JsonProperty(PropertyName = "List")]
        public List<ImageInfo> ImageList { get; private set; }

        public RegulaServiceRequest(string image)
        {
            ProcessParam = new RegulaProcessParam();

            ImageList = new List<ImageInfo>()
            {
                new ImageInfo()
                {
                    ImageData = new ImageData()
                    {
                        Image = image
                    },
                    Light = 6,
                    PageIndex = 0
                }
            };
        }

        public ExternalTypeEnum GetType()
        {
            return ExternalTypeEnum.Regula;
        }
    }
}
