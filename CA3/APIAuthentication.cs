using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CA3
{
    public static class ServiceExtensions
    {
        public static async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url); //makes request 
            request.Headers.Add("X-Auth-Token", "46e2ee19159948149076ae0e2fd9f90e"); //auth needed with access token recived from email once signed up

            var response = await httpClient.SendAsync(request);
            response.Headers.Add("Access-Control-Allow-Origin", "*"); //allows for CORS 
            response.EnsureSuccessStatusCode();

            var responseBytes = await response.Content.ReadAsByteArrayAsync();

            return JsonSerializer.Deserialize<T>(responseBytes);
        }
    }
}
