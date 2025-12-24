using MitchNoFluff.ApiClients;

namespace MitchNoFluff.Services
{
    public class FootballApiService(FootballApiClient client) : IFootballApiService
    {
        private readonly FootballApiClient _client = client;
                
        public Task<string> GetDataAsync(string endpoint) => _client.GetAsync(endpoint);
    }
}
