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
            try
            {
                BookModel bookModel = _mapper.Map<Book, BookModel>(book);
                await _bookData.CreateBookAsync(bookModel);
                return 0;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> UpdateBookAsync(Book book)
        {
            try
            {
                var bookModel = _mapper.Map<Book, BookModel>(book);
                await _bookData.UpdateBookAsync(bookModel);
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> DeleteBookAsync(int bookId)
        {
            try
            {
                await _bookData.DeleteBookAsync(bookId);
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Book>> GetBooksBySearchValueAsync(string searchValue)
        {
            try
            {
                IEnumerable<Book> books = _mapper.Map<IEnumerable<BookModel>, IEnumerable<Book>>(await _bookData.GetBooksBySearchValueAsync(searchValue));
                return books;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Book>> GetBookByBookIdAsync(int bookId)
        {
            try
            {
                IEnumerable<Book> book = _mapper.Map<IEnumerable<BookModel>, IEnumerable<Book>>(await _bookData.GetBookByBookIdAsync(bookId));
                return book;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            try
            {
                IEnumerable<Book> books = _mapper.Map<IEnumerable<BookModel>, IEnumerable<Book>>(await _bookData.GetAllBooksAsync());
                return books;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
