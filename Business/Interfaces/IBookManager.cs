using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using ModelDTOs;

namespace Business.Interfaces
{
    public interface IBookManager
    {
        Task<int> CreateBookAsync(Book book);
        Task<int> UpdateBookAsync(Book book);
        Task<int> DeleteBookAsync(int bookId);
        Task<IEnumerable<BookDTO>> GetBooksBySearchValueAsync(string searchValue);
        Task<IEnumerable<BookDTO>> GetBookByBookIdAsync(int bookId);
        Task<IEnumerable<BookDTO>> GetAllBooksAsync();
    }
}
