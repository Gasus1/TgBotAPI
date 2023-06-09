using API_IPBot2.Models;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace API_IPBot2.Clients
{
    public class IPClient
    {
        private HttpClient HttpClient;
        public static string _adress;
        public IPClient()
        {
            _adress = Constants.adress;
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(_adress);
        }
        public async Task<IP_Data> GetDataAsync(string query)
        {
            var response = await HttpClient.GetAsync($"{query}");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<IP_Data>(content);
            return result;
        }
        public async Task<IP_Data> GetUserDataAsync()
        {
            var response = await HttpClient.GetAsync("");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<IP_Data>(content);
            return result;
        }

        public async Task<IPCountry> GetCountryAsync()
        {
            var response = await HttpClient.GetAsync("?fields=country");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<IPCountry>(content);
            return result;
        }
        public async Task<Query> GetQueryAsync()
        {
            var response = await HttpClient.GetAsync("?fields=query");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Query>(content);
            return result;
        }
        public async Task<RegionName> GetRegionAsync()
        {
            var response = await HttpClient.GetAsync("?fields=regionName");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<RegionName>(content);
            return result;
        }
        public async Task<City> GetCityAsync()
        {
            var response = await HttpClient.GetAsync("?fields=city");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<City>(content);
            return result;
        }
        public async Task<Coord> GetCoordAsync()
        {
            var response = await HttpClient.GetAsync("");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Coord>(content);
            return result;
        }
        public async Task<Isp> GetIspAsync()
        {
            var response = await HttpClient.GetAsync("?fields=isp");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Isp>(content);
            return result;
        }
        public async Task<Orgs> GetOrgsAsync()
        {
            var response = await HttpClient.GetAsync("");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Orgs>(content);
            return result;
        }
    }
}
