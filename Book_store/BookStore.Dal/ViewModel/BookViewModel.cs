using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Dal.ViewModel
{
    public class BookViewModel
    {
        public BookViewModel(Book book)
        {
            Book = new BookDto(book);
        }
        public BookViewModel(IReadOnlyCollection<Book> books)
        {
            Collection = books.Select(book => new BookDto(book)).ToList();
        }
        public IReadOnlyCollection<BookDto> Collection { get; }
        public BookDto Book { get; }
    }
}
