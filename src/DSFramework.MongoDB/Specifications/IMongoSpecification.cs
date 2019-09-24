﻿using DSFramework.Domain.Abstractions.Specifications;
using MongoDB.Driver;

namespace DSFramework.MongoDB.Specifications
{
    public interface IMongoSpecification<TDocument> : ISpecification<TDocument>
    {
        bool AdditionalDomainFilteringIsRequired { get; }

        FilterDefinition<TDocument> BuildFilter(FilterDefinitionBuilder<TDocument> filterBuilder);
    }
}