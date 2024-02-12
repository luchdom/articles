using SharedKernel.SeedWork;

namespace Articles.Domain.AggregateModels.ArticleAggregates;

public sealed record ArticleCreatedEvent(int UserId, int ArticleId) : IDomainEvent;
