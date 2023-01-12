using Dapper;
using Dapper.Contrib.Extensions;
using DapperDemo.Data;
using DapperDemo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DapperDemo.Repository
{
    public class CompanyRepositoryContrib : ICompanyRepository
    {

        private IDbConnection db;

        public CompanyRepositoryContrib()
        {
            db = new SqlConnection("Server=(localdb)\\ProjectModels;Database=dapper;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public Company Add(Company company)
        {
            var id = db.Insert(company);
            company.CompanyId = (int)id;
            return company;
        }

        public Company Find(int id)
        {
            return db.Get<Company>(id);
        }

        public List<Company> GetAll()
        {
            /** add the store procedure */
            return db.GetAll<Company>().ToList();
        }

        public void Remove(int id)
        {
            db.Delete(new Company { CompanyId = id });
        }

        public Company Update(Company company)
        {
            db.Update(company);
            return company;
        }
    }
}
