using BookStore.Dal.Context;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<ICollection<User>> GetTopTen(CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;
            return await _bookStoreDbContext.Users.Take(maxTop).ToListAsync(cancellationToken);
        }
    }
}
