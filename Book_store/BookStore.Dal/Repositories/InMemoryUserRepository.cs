using BookStore.Dal.ViewModel;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public async Task<UserViewModel> GetTopTen(CancellationToken cancellationToken = default)
        {
            var collection = new List<User>
            {
                new User
                {
                    Id=1,
                    FirstName= "Faruk"
                }
            };
            return new UserViewModel(collection);
        }

        public Task<int> Save(UserDto user, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
