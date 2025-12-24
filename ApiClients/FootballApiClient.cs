namespace MitchNoFluff.ApiClients
{
    public class FootballApiClient
    {
        private readonly HttpClient _httpClient;

        public FootballApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
