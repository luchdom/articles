namespace Articles.Api.Dtos;

public class ArticleDto
{
    public int ArticleId { get; set; }

    public string Slug { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Body { get; set; }
}
