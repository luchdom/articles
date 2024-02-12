namespace Articles.Api.Dtos;

public record NewArticleRequest
{
    public NewArticleRequest(int userId, string title, string description, string body)
    {
        UserId = userId;
        Title = title;
        Description = description;
        Body = body;
    }

    public int UserId { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Body { get; set; }
}
