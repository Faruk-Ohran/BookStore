using BookStore.Domain;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Dal.Repositories
{
    public interface IUserRepository
    {
        Task<ICollection<User>> GetTopTen(CancellationToken cancellationToken=default);
    }
}
