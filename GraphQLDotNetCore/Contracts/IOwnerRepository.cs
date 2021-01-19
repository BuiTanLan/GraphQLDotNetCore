using System.Collections.Generic;
using GraphQLDotNetCore.Entities;

namespace GraphQLDotNetCore.Contracts
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();

    }
}
