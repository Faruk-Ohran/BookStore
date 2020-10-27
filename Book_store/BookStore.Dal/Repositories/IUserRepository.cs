using BookStore.Dal.ViewModel;
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
        Task<UserViewModel> GetTopTen(CancellationToken cancellationToken=default);
        Task<int> Save(UserDto user, CancellationToken cancellationToken =default);
    }
}
