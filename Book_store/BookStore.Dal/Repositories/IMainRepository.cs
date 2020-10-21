using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Repositories
{
    public interface IMainRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity obj);
        TEntity Remove(int id);
        TEntity Update(int id);
    }
}
