using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Common.Models;
using DataAccess.Interfaces;
using ModelDTOs;

namespace Business
{
	public class BookManager : IBookManager
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookManager(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateBookAsync(Book book)
        {
            return await _bookRepository.CreateBookAsync(book);
        }

        public async Task<int> UpdateBookAsync(Book book)
        {

            return await _bookRepository.UpdateBookAsync(book);
        }

        public async Task<int> DeleteBookAsync(int bookId)
        {
            return await _bookRepository.DeleteBookAsync(bookId);
        }

        public async Task<IEnumerable<BookDTO>> GetBooksBySearchValueAsync(string searchValue)
        {
            return _mapper.Map<IEnumerable<Book>, IEnumerable<BookDTO>>(await _bookRepository.GetBooksBySearchValueAsync(searchValue));
        }

        public async Task<IEnumerable<BookDTO>> GetBookByBookIdAsync(int bookId)
        {
            return _mapper.Map<IEnumerable<Book>, IEnumerable<BookDTO>>(await _bookRepository.GetBookByBookIdAsync(bookId));
        }

        public async Task<IEnumerable<BookDTO>> GetAllBooksAsync()
        {
            return _mapper.Map<IEnumerable<Book>, IEnumerable<BookDTO>>(await _bookRepository.GetAllBooksAsync());
        }
    }
}
