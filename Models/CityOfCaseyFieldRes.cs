using Newtonsoft.Json;

namespace GreenITBlazor.Models
{
    public class CityOfCaseyFieldRes
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("emission_source")]
        public string Type { get; set; }

        [JsonProperty("average_intensity_kwh_per_customer_per_annum")]
        public double? AveKwhPcPa { get; set; }

        [JsonProperty("average_intensity_gj_per_customer_per_annum")]
        public double? AveGjPcPa { get; set; }
    }
}
