using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelDTOs;

namespace BlazorClient.Services.Interfaces
{
        public interface IBookService
        {
            //Task<int> CreateBookAsync(BookDTO book);
            //Task<int> UpdateBookAsync(BookDTO book);
            //Task<int> DeleteBookAsync(int bookId);
            //Task<List<BookDTO>> GetBooksBySearchValueAsync(string searchValue);
            //Task<BookDTO> GetBookByBookIdAsync(int bookId);
            public Task<IEnumerable<BookDTO>> GetAllBooksAsync();
        }
}
