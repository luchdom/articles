using SharedKernel.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Domain.AggregateModels.ArticleAggregates;
public sealed record ArticleUpdatedEvent(int ArticleId) : IDomainEvent;
