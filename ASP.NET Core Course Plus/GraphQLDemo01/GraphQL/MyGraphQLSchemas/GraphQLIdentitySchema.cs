using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//
using GraphQL;
using GraphQL.Types;
using GraphQLDemo01.GraphQL.MyGraphQLQuery;

namespace GraphQLDemo01.GraphQL.MyGraphQLSchemas
{
    public class GraphQLIdentitySchema : Schema
    {
        public GraphQLIdentitySchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<IdentityGraphQLQuery>();
        }
    }
}
