using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenITBlazor.Models
{
    public class CityOfCaseyRes
    {
        [JsonProperty("records")]
        public List<CityOfCaseyRecordRes> Records { get; set; }
    }


}
