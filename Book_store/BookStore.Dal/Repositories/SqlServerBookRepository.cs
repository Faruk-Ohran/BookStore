using BookStore.Dal.Context;
using BookStore.Dal.ViewModel;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Dal.Repositories
{
    public class SqlServerBookRepository : IBookRepository
    {
        private readonly BookStoreDbContext _bookStoreDbContext;
        public SqlServerBookRepository(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }

        public async Task<BookViewModel> GetById(int id, CancellationToken cancellationToken = default)
        {
            var book = await _bookStoreDbContext.Books.FirstOrDefaultAsync(x=>x.Id==id, cancellationToken);
            return new BookViewModel(book);
        }

        public async Task<BookViewModel> GetTopTen(CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;
            var collection = await _bookStoreDbContext.Books.Take(maxTop).ToListAsync(cancellationToken);
            return new BookViewModel(collection);
        }
    }
}
