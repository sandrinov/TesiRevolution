using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mtfbpwa.Shared;
using System.Net.Http;
using System.Net.Http.Json;

namespace mtfbpwa.Client.Services
{
    public class ApiService
    {
        private readonly HttpClient httpClient;

        public ApiService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<List<Track>> GetTracks()
        {
            var list = new List<Track>();
            try
            {
                string Url = "Tracks";
                list = await httpClient.GetFromJsonAsync<List<Track>>(Url);
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }

            return list;
        }
    }
}
