using BlazorAPIClient.Dtos;
using System.Net.Http.Json;

namespace BlazorAPIClient.DataServices
{
    public class RESTSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient _httpClient;
        public RESTSpaceXDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<LaunchDto[]> GetAllLaunches()
        {
            return await _httpClient.GetFromJsonAsync<LaunchDto[]>("/rest/launches");
        }
    }
}
