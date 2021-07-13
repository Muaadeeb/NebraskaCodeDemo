using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Common.Models;
using DataAccess.Interfaces;

namespace Business
{
	public class BookManager : IBookManager
    {
        private readonly IBookRepository _bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<int> CreateBookAsync(Book book)
        {

            var result = await _bookRepository.CreateBookAsync(book);
            return result;
        }

        public async Task<int> UpdateBookAsync(Book book)
        {

            var result = await _bookRepository.UpdateBookAsync(book);
            return result;
        }

        public async Task<int> DeleteBookAsync(int bookId)
        {
            var result = await _bookRepository.DeleteBookAsync(bookId);
            return result;
        }

        public async Task<List<Book>> GetBooksBySearchValueAsync(string searchValue)
        {
            var results = await _bookRepository.GetBooksBySearchValueAsync(searchValue);

            return results;
        }

        public async Task<Book> GetBookByBookIdAsync(int bookId)
        {
            var result = await _bookRepository.GetBookByBookIdAsync(bookId);

            return result;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            var results = await _bookRepository.GetAllBooksAsync();
            return results;
        }
    }
}
