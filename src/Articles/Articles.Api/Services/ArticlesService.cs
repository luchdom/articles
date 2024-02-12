using Articles.Api.Dtos;
using Articles.Api.Services.Interfaces;
using FluentResults;

namespace Articles.Api.Services;

public class ArticlesService : IArticlesServices
{
    public async Task<Result<ArticleDto>> CreateArticleAsync(NewArticleRequest request)
    {
        return Result.Fail("Teste");
        throw new NotImplementedException();
    }
}
