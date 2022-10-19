using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RaceReader.Clients
{
    public class F1Client : IF1Client
    {
        private readonly string _methodURL;
        private readonly HttpClient _httpClient;

        public F1Client(HttpClient httpClient, IConfiguration _configuration)
        {
            _httpClient = httpClient;
            _methodURL = _configuration["RaceDataURL:Method"];
        }

        public async Task<Root> GetF1Data()
        {
            var response = await _httpClient.GetAsync(_methodURL);
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Root>(jsonContent);
        }
    }
}
