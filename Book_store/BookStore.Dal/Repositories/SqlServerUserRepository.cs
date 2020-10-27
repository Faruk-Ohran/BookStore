using BookStore.Dal.Context;
using BookStore.Dal.ViewModel;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Dal.Repositories
{
    public class SqlServerUserRepository : IUserRepository
    {
        private readonly BookStoreDbContext _bookStoreDbContext;
        public SqlServerUserRepository(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }
        public async Task<UserViewModel> GetTopTen(CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;
            var collection = await _bookStoreDbContext.Users.Take(maxTop).ToListAsync(cancellationToken);
            return new UserViewModel(collection);
        }

        public async Task<int> Save(UserDto user, CancellationToken cancellationToken = default)
        {
            var userDomain = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Adress = user.Adress,
                Password = Guid.NewGuid().ToString("n")
        };
            await _bookStoreDbContext.Users.AddAsync(userDomain, cancellationToken);
            await _bookStoreDbContext.SaveChangesAsync(cancellationToken);

            return userDomain.Id;
        }
    }
}
