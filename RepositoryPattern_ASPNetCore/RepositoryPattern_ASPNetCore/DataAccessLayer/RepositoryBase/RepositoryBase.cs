using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.RepositoryBase;
using RepositoryPattern_ASPNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.RepositoryBase
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DevDBContext _dbcontext;
        private DbSet<TEntity> _entitySet;

        public RepositoryBase(DevDBContext context)
        {
            _dbcontext = context;
            _entitySet = _dbcontext.Set<TEntity>();
        }

        public bool Add(TEntity entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                _entitySet.Add(entity);
                _dbcontext.SaveChanges();
                return true;
            }
        }

        public bool Delete(TEntity entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                _entitySet.Remove(entity);
                _dbcontext.SaveChanges();
                return true;
            }
        }

        public IEnumerable<TEntity> FindAll()
        {
            return _entitySet.AsEnumerable();
        }

        public TEntity FindByID(long ID)
        {
            return _entitySet.Find(ID);
        }

        public bool Update(TEntity entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                _entitySet.Attach(entity);
                _dbcontext.SaveChanges();
                return true;
            }

        }
    }

}
