namespace MitchNoFluff.Services
{
    public class FootballApiService : IFootballApiService
    {
        private readonly HttpClient _httpClient;

        public FootballApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //WIP: Implement methods to interact with the football API
        public async Task<string> GetFootballDataAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Request to {endpoint} failed with status code {response.StatusCode}");
            }

            return await response.Content.ReadAsStringAsync();
        }
    }
}
