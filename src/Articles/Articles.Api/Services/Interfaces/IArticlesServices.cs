using Articles.Api.Dtos;
using FluentResults;

namespace Articles.Api.Services.Interfaces;

public interface IArticlesServices
{
    Task<Result<ArticleDto>> CreateArticleAsync(NewArticleRequest request);
}