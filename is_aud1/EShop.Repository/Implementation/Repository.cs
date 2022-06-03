using EShop.Domain.DomainModels;
using EShop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
