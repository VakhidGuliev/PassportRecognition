using Newtonsoft.Json;

namespace ExternalService.Model.Accessory
{
    public class ImageData
    {
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }
    }
}
