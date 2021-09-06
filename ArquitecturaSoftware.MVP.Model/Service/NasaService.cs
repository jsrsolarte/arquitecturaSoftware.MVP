using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArquitecturaSoftware.MVP.Model.Service
{
    public class NasaService
    {
        private readonly HttpClient _client;

        public NasaService()
        {
            _client = new HttpClient();
        }

        public async Task<RandomImage> GetRandomImageAsync()
        {
            int r = new Random().Next(0, 80);

            DateTime date = DateTime.Now.AddDays(-r);

            HttpResponseMessage response = await _client.GetAsync($"https://api.nasa.gov/planetary/apod?api_key=A01Im8ia3fVOVtwGv1qt7Zaq78FUeg8FR6sQAOm0&date={date:yyyy-MM-dd}");
            string result = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<RandomImage>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
        }
    }
}