using GreenITBlazor.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GreenITBlazor.Services
{
    public class ApiService
    {
        HttpClient client;
        public ApiService() {
            client = new HttpClient();
        }

        public async Task<bool> ValidatePostcode(string postcode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://data.casey.vic.gov.au/api/records/1.0/search/?dataset=summary-residential-community-data&rows=1&facet=postcode&refine.postcode={postcode}");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            CityOfCaseyRes res = JsonConvert.DeserializeObject<CityOfCaseyRes>(await response.Content.ReadAsStringAsync());
            if(res.Records.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
