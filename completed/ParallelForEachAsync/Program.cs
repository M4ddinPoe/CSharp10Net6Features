using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

var userHandlers = new[]
{
    "users/okyrylchuk",
    "users/shanselman",
    "users/jaredpar",
    "users/davidfowl"
};

using HttpClient client = new()
{
    BaseAddress = new Uri("https://api.github.com"),
};
client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("DotNet", "6"));

ParallelOptions parallelOptions = new()
{
    MaxDegreeOfParallelism = 3
};

await Parallel.ForEachAsync(userHandlers, parallelOptions, async (uri, token) =>
{
    var user = await client.GetFromJsonAsync<GitHubUser>(uri, token);
    Console.WriteLine($"Name: {user.Name}\nBio: {user.Bio}\n");
});

public class GitHubUser
{
    public string Name { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
}

// Thanks to Oleg Kyrylchuk: https://twitter.com/okyrylchuk/status/1449838369660362752?s=21