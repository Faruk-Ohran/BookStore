using BookStore.Domain;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Dal.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        public async Task<ICollection<User>> GetTopTen(CancellationToken cancellationToken = default)
        {
            return new List<User>
            {
                new User
                {
                    Id=1,
                    FirstName= "Faruk"
                }
            };
        }
    }
}
