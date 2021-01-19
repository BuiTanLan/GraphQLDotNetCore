
using System;
using GraphQL.Types;
using GraphQL.Utilities;
using GraphQLDotNetCore.GraphQL.GraphQLQueries;

namespace GraphQLDotNetCore.GraphQL.GraphQLSchemas
{
    public class AppSchema: Schema
    {
        public AppSchema(IServiceProvider provider): base(provider)
        {
            Query = provider.GetRequiredService<AppQuery>();
        }
    }
}