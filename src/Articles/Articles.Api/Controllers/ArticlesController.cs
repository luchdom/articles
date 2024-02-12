using Articles.Api.Dtos;
using Articles.Api.Services.Interfaces;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Articles.Api.Controllers;

[Route("/v{version:apiVersion}/[controller]")]
[ApiController]
[ApiVersion(ApiVersion)]
public class ArticlesController(IArticlesServices articlesServices) : ControllerBase
{
    private const string ApiVersion = "1";
    private readonly IArticlesServices _articlesServices = articlesServices;

    [HttpPost]
    [ProducesResponseType(typeof(void), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(void), StatusCodes.Status500InternalServerError)]
    [ProducesResponseType(typeof(ArticleDto), StatusCodes.Status201Created)]
    public async Task<IActionResult> NewArticle(NewArticleRequest request)
    {
        var userRequest = request with { UserId = 123456789 };
        var result = await _articlesServices.CreateArticleAsync(userRequest);
        if (result.IsFailed)
            return BadRequest(result.Errors);

        return Created($"{Request.Scheme}://{Request.Host}/v{ApiVersion}/articles/{result.Value.ArticleId}", result);
    }

}
