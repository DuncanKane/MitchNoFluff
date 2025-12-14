namespace MitchNoFluff.Services
{
    public interface IFootballApiService
    {
        Task<string> GetFootballDataAsync(string endpoint);
    }
}