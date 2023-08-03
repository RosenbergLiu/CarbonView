using GreenITBlazor.Models;
using Newtonsoft.Json;

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

        public async Task<List<CityOfCaseyRecordRes>> GetData(string postcode)
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

                    return res.Records;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return null;
        }
    }
}
