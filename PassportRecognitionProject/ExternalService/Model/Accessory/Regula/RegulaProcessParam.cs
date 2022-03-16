using Newtonsoft.Json;

namespace ExternalService.Model.Accessory
{
    public class RegulaProcessParam
    {
        [JsonProperty(PropertyName = "scenario")]
        public string Scenario { get; set; } = "FullProcess";

        [JsonProperty(PropertyName = "doublePageSpread")] 
        public bool DoublePageSpread { get; set; } = true;

        [JsonProperty(PropertyName = "measureSystem")]
        public int MeasureSystem { get; set; } = 0;

        [JsonProperty(PropertyName = "dateFormat")]
        public string DateFormat { get; set; } = "dd.MM.yyyy";

        [JsonProperty(PropertyName = "alreadyCropped")]
        public bool AlreadyCropped { get; set; } = false;
    }
}
