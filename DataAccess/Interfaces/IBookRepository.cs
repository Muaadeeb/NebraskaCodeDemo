using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace DataAccess.Interfaces
{
    public interface IBookRepository
    {
        Task<int> CreateBookAsync(Book book);
        Task<int> UpdateBookAsync(Book book);
        Task<int> DeleteBookAsync(int bookId);
        Task<IEnumerable<Book>> GetBooksBySearchValueAsync(string searchValue);
        Task<IEnumerable<Book>> GetBookByBookIdAsync(int bookId);
        Task<IEnumerable<Book>> GetAllBooksAsync();
    }
}
