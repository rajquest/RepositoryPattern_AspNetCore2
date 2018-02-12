using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.RepositoryBase;
using RepositoryPattern_ASPNetCore.Models;

namespace DataAccessLayer.Repository
{
    public interface IEmployeeRepository : IRepository<Emloyee>
    {
    }
}
