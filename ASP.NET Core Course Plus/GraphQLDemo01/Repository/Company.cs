using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//
using GraphQLDemo01.Models;

namespace GraphQLDemo01.Repository
{
    public class Company
    {
        List<CompanyModel> companies = new List<CompanyModel>();

        public Company()
        {
            companies.Add(new CompanyModel() { CompanyID = 1, Name = "Tamtom", Address = "Jannat Abad, Tehran" });
            companies.Add(new CompanyModel() { CompanyID = 2, Name = "Microsoft", Address = "Redmond, WA" });
        }

        public List<CompanyModel> List() => companies;

    }
}
