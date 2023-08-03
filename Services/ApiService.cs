using GreenITBlazor.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace GreenITBlazor.Services
{
    public class ApiService
    {
        HttpClient _client;

        public CityOfCaseyRes res;

        public ApiService() {
            _client = new HttpClient();
        }

        public async Task<bool> ValidatePostcode(string postcode)
        {
            res = new CityOfCaseyRes();
            string uri = Constants.CityOfCaseyUrl + postcode;

            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    res = JsonConvert.DeserializeObject<CityOfCaseyRes>(content);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if(res != null)
            {
                if(res.Records.Count > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
