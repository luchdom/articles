using Articles.Domain.AggregateModels.UserAggregates;
using SharedKernel.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Domain.AggregateModels.ArticleAggregates;
public class Article : Entity
{
    public int ArticleId { get; set; }

    public Slug Slug { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Body { get; set; }

    public User? Author { get; set; }
}
