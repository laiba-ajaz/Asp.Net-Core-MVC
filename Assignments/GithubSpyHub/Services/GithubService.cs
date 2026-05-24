using System.Net.Http;
using System.Threading.Tasks;

public class GithubService
{
    private readonly HttpClient _httpClient;

    public GithubService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetGithubProfileAsync(string username)
    {
        var url = $"https://api.github.com/users/{username}";

        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("GitHubSpyApp");

        return await _httpClient.GetStringAsync(url);
    }
}