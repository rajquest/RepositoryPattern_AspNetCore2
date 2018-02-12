using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer.RepositoryBase;
using RepositoryPattern_ASPNetCore.Models;

namespace DataAccessLayer.Repository
{
    public class EmployeeRepository : RepositoryBase<Emloyee> ,IEmployeeRepository
    {
        public EmployeeRepository(DevDBContext dbContext) : base(dbContext)
        {

        }
    }
}
