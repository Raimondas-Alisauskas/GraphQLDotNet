﻿using GraphQL.Types;
using GraphQL.Utilities;
using GraphQLDotNetCore.GraphQL.Queries;
using System;


namespace GraphQLDotNetCore.GraphQL.Schemas
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<AppQuery>();
            Mutation = provider.GetRequiredService<AppMutation>();
        }
    }
}
