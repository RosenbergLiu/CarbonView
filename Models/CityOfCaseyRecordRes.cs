using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenITBlazor.Models
{
    public class CityOfCaseyRecordRes
    {
        [JsonProperty("recordid")]
        public string RecordId { get; set; }

        [JsonProperty("fields")]
        public CityOfCaseyFieldRes Fields { get; set; }
    }
}
