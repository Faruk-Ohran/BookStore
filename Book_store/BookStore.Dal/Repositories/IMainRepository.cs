using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Repositories
{
    public interface IMainRepository
    {
        Object Add(Object obj);
        Object Remove(int id);
        Object Update(int id);
    }
}
