using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Common.Models;
using DataAccess.Interfaces;
using NebraskaCodeDataLibraryDemo.Data.Interfaces;
using NebraskaCodeDataLibraryDemo.Db.Models;

namespace DataAccess
{
	public class BookRepository : IBookRepository
    {
        private readonly IBookData _bookData;
        private readonly IMapper _mapper;

        public BookRepository(IBookData bookData, IMapper mapper)
        {
            _bookData = bookData;
            _mapper = mapper;
        }

        public async Task<int> CreateBookAsync(Book book)
        {
            var bookModel = _mapper.Map<Book, BookModel>(book);
            return await _bookData.CreateBookAsync(bookModel);
        }

        public async Task<int> UpdateBookAsync(Book book)
        {
            var bookModel = _mapper.Map<Book, BookModel>(book);
            return await _bookData.UpdateBookAsync(bookModel);
        }

        public async Task<int> DeleteBookAsync(int bookId)
        {
            var result = await _bookData.DeleteBookAsync(bookId);
            return result;
        }

        public async Task<IEnumerable<Book>> GetBooksBySearchValueAsync(string searchValue)
        {
            IEnumerable<Book> books = _mapper.Map<IEnumerable<BookModel>, IEnumerable<Book>>(await _bookData.GetBooksBySearchValueAsync(searchValue));
            return books;
        }

        public async Task<IEnumerable<Book>> GetBookByBookIdAsync(int bookId)
        {
            IEnumerable<Book> book = _mapper.Map<IEnumerable<BookModel>, IEnumerable<Book>>(await _bookData.GetBookByBookIdAsync(bookId));
            return book;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            IEnumerable<Book> books = _mapper.Map<IEnumerable<BookModel>, IEnumerable<Book>>(await _bookData.GetAllBooksAsync());
            return books;
        }
	}
}
