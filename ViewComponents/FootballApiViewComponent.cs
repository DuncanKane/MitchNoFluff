using MitchNoFluff.Services;

namespace MitchNoFluff.ViewComponents
{
    public class FootballApiViewComponent(IFootballApiService footballApiService)
    {
        private readonly IFootballApiService _footballApiService = footballApiService;

        public async Task<string> InvokeAsync(string endpoint)
        {
            var data = await _footballApiService.GetDataAsync(endpoint);
            return data;
        }
    }
}
