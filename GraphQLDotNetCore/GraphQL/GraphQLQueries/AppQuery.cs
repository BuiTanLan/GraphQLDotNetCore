using GraphQL.Types;
using GraphQLDotNetCore.Contracts;
using GraphQLDotNetCore.GraphQL.GraphQLSchemas;

namespace GraphQLDotNetCore.GraphQL.GraphQLQueries
{
    public class AppQuery: ObjectGraphType
    {
        public AppQuery(IOwnerRepository repository)
        {
            Field<ListGraphType<OwnerType>>(
            "owners",
            resolve: context => repository.GetAll()
        );
        }
    }
}