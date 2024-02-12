using FluentResults;
using System.Text;
using System.Text.RegularExpressions;

namespace Articles.Domain.AggregateModels.ArticleAggregates;
public sealed partial record Slug
{
    private Slug(string value) => Value = value;
    public string Value { get; set; }

    public static Result<Slug> Create(string articleTitle)
    {
        if (string.IsNullOrEmpty(articleTitle))
        {
            return Result.Fail("Title can not be empty or null to create slug");
        }

        return Result.Ok(new Slug(CreateSlug(articleTitle)));
    }

    private static string CreateSlug(string input)
    {

        //First to lower case
        input = input.ToLowerInvariant();

        //Remove all accents
        var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(input);
        input = Encoding.ASCII.GetString(bytes);

        //Replace spaces
        input = ReplaceSpaces().Replace(input, "-");

        //Remove invalid chars
        input = InvalidCharReplacement().Replace(input, "");

        //Trim dashes from end
        input = input.Trim('-', '_');

        //Replace double occurences of - or _
        input = ReplaceDashOrUnderscore().Replace(input, "$1");

        return input;
    }

    [GeneratedRegex(@"[^a-z0-9\s-_]", RegexOptions.Compiled)]
    private static partial Regex InvalidCharReplacement();
    [GeneratedRegex(@"([-_]){2,}", RegexOptions.Compiled)]
    private static partial Regex ReplaceDashOrUnderscore();
    [GeneratedRegex(@"\s", RegexOptions.Compiled)]
    private static partial Regex ReplaceSpaces();
}
