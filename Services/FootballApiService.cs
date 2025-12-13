namespace MitchNoFluff.Services
{
    public class FootballApiService : IFootballApiService
    {
        private readonly HttpClient _httpClient;

        public FootballApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetFootballDataAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
