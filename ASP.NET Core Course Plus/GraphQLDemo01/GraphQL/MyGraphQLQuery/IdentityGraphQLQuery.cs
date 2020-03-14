using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//
using GraphQL.Types;
using GraphQLDemo01.GraphQL.MyGraphQLTypes;
using GraphQLDemo01.Repository;

namespace GraphQLDemo01.GraphQL.MyGraphQLQuery
{
    public class IdentityGraphQLQuery : ObjectGraphType
    {
        public IdentityGraphQLQuery()
        {
            Customer customer = new Customer();
            Field<ListGraphType<GraphQLCustomerType>>(name: "Customers", resolve: context => customer.List());

            Company company = new Company();
            Field<ListGraphType<GraphQLCompanyType>>(name: "Companies", resolve: context => company.List());

        }
    }
}
