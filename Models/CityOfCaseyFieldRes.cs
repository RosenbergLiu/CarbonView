using Newtonsoft.Json;

namespace GreenITBlazor.Models
{
    public class CityOfCaseyFieldRes
    {
        [JsonIgnore]
        private string _yearStr;

        [JsonProperty("year")]
        public string YearStr
        {
            get
            {
                return _yearStr;
            }
            set
            {
                _yearStr = value;
                if (Int32.TryParse(_yearStr, out int year))
                {
                    Year = year;
                }
            }
        }

        [JsonProperty("emission_source")]
        public string Type { get; set; }

        [JsonProperty("average_intensity_kwh_per_customer_per_annum")]
        public double? AveKwhPcPa { get; set; }

        [JsonIgnore]
        private double _AveGjPcPa;

        [JsonProperty("average_intensity_gj_per_customer_per_annum")]
        public double? AveGjPcPa {
            get
            {
                return _AveGjPcPa;
            }
            set
            {
                _AveGjPcPa = (double)value;
                AveMjPcPa = _AveGjPcPa * 1000;
            }
        }

        [JsonIgnore]
        public double? AveMjPcPa { get; set; }

        [JsonIgnore]
        public int Year { get; private set; }
    }
}
