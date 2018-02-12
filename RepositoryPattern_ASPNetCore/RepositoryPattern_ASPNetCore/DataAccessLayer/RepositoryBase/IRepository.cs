using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.RepositoryBase
{
    public interface IRepository<T> where T : class
    {
        T FindByID(long ID);
        IEnumerable<T> FindAll();
        Boolean Add(T entity);
        Boolean Update(T entity);
        Boolean Delete(T entity);
    }

}
