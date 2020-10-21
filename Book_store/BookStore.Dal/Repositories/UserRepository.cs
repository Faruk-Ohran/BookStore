using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Repositories
{
    class UserRepository : IUserRepository
    {
        public object Add(object obj)
        {
            User user = obj as User;
            return user;
        }

        public object Remove(int id)
        {
            throw new NotImplementedException();
        }

        public object Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
