using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//
using GraphQLDemo01.Models;
using GraphQL.Types;

namespace GraphQLDemo01.GraphQL.MyGraphQLTypes
{
    public class GraphQLCustomerType : ObjectGraphType<CustomerModel>
    {
        public GraphQLCustomerType()
        {
            Field(c => c.CustomerID);
            Field(c => c.FirstName);
            Field(c => c.LastName);
            Field(c => c.Age);
            Field(c => c.City);
        }
    }
}
