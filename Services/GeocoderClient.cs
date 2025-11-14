using GeocoderProxy.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace GeocoderProxy.Services
{
    public class GeocoderClient
    {
        private readonly HttpClient _httpClient;
        private readonly GeocoderSettings _settings;

        public GeocoderClient(HttpClient httpClient, IOptions<GeocoderSettings> options)
        {
            _httpClient = httpClient;
            _settings = options.Value;
        }

        public async Task<GeocodeResponse> GetGeocodeAsync(GeocodeRequest request)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, _settings.AmazonUrl);

            // Add headers
            httpRequest.Headers.Add("Accept", "application/json");
            httpRequest.Headers.Add("host", _settings.AmazonHost);
            httpRequest.Headers.Add("x-api-key", _settings.ApiKey);

            // Set JSON body
            httpRequest.Content = JsonContent.Create(request);

            // Send request
            var response = await _httpClient.SendAsync(httpRequest);

            response.EnsureSuccessStatusCode();

            // Deserialize response
            var result = await response.Content.ReadFromJsonAsync<GeocodeResponse>();
            return result!;
        }
    }
}

