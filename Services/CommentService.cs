using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

public class CommentService
{
    private readonly HttpClient _httpClient;
    private List<Comment> _comments;

    public CommentService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Comment>> GetCommentsAsync()
    {
        if (_comments == null)
        {
            _comments = await _httpClient.GetFromJsonAsync<List<Comment>>("https://jsonplaceholder.typicode.com/comments");
        }
        return _comments;
    }

    public async Task<List<Comment>> SearchCommentsAsync(string searchText)
    {
        var comments = await GetCommentsAsync();
        return comments
            .Where(c => c.Body.Contains(searchText, System.StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}

public class Comment
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Body { get; set; }
}
