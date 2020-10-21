using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Repositories
{
    class UserRepository : IUserRepository
    {
        public User Add(User user)
        {
            return user;
        }

        public User Remove(int id)
        {
            throw new NotImplementedException();
        }

        public User Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
