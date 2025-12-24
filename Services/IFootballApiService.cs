namespace MitchNoFluff.Services
{
    public interface IFootballApiService
    {
        Task<string> GetDataAsync(string endpoint);
        //Task<string> GetFootballDataAsync(string endpoint);
    }
}