using Newtonsoft.Json;

namespace ExternalService.Model.Accessory
{
    public class ImageInfo
    {
        [JsonProperty(PropertyName = "ImageData")]
        public ImageData ImageData { get; set; }

        [JsonProperty(PropertyName = "light")]
        public int Light { get; set; } = 6;

        [JsonProperty(PropertyName = "page_idx")]
        public int PageIndex { get; set; } = 0;
    }
}
