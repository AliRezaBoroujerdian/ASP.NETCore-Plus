using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//
using GraphQLDemo01.Models;
using GraphQL.Types;

namespace GraphQLDemo01.GraphQL.MyGraphQLTypes
{
    public class GraphQLCompanyType : ObjectGraphType<CompanyModel>
    {
        public GraphQLCompanyType()
        {
            Field(c => c.CompanyID);
            Field(c => c.Name);
            Field(c => c.Address);
        }
    }
}
