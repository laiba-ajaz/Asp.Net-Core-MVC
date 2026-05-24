namespace GitHubSpyHub.Models
{
    public class GithubProfile
    {
        [System.Text.Json.Serialization.JsonPropertyName("login")]
        public string Username { get; set; } = string.Empty;

        [System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; } = string.Empty;

        [System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string ProfileUrl { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        public string Blog { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [System.Text.Json.Serialization.JsonPropertyName("public_repos")]
        public int PublicRepos { get; set; }

        public int Followers { get; set; }
        public int Following { get; set; }
    }
}