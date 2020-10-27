using BookStore.Dal.ViewModel;
using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Dal.Repositories
{
    public interface IBookRepository
    {
        Task<BookViewModel> GetTopTen(CancellationToken cancellationToken = default);
        Task<BookViewModel> GetById(int id, CancellationToken cancellationToken = default);
    }
}
