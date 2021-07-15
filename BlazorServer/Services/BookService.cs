using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AutoMapper;
using BlazorServer.Services.Interfaces;
using Business.Interfaces;
using Common.Models;
using ModelDTOs;

namespace BlazorServer.Services
{
    public class BookService : IBookService
    {
        private readonly IBookManager _bookManager;
        private readonly IMapper _mapper;

        public BookService(IBookManager bookManager, IMapper mapper)
        {
            _bookManager = bookManager;
            _mapper = mapper;
        }

        public async Task<int> CreateBookAsync(BookDTO bookDto)
        {
            Book book = _mapper.Map<BookDTO, Book>(bookDto);
            return await _bookManager.CreateBookAsync(book);
        }

        public async Task<int> UpdateBookAsync(BookDTO bookDto)
        {
            Book book = _mapper.Map<BookDTO, Book>(bookDto);
            return await _bookManager.UpdateBookAsync(book);
        }

        public async Task<int> DeleteBookAsync(int bookId)
        {
            return await _bookManager.DeleteBookAsync(bookId);
        }

        public async Task<IEnumerable<BookDTO>> GetBooksBySearchValueAsync(string bookSearchValue)
        {
            return await _bookManager.GetBooksBySearchValueAsync(bookSearchValue);
        }

        public async Task<BookDTO> GetBookByBookIdAsync(int bookId)
        {
            var result = await _bookManager.GetBookByBookIdAsync(bookId);
            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<BookDTO>> GetAllBooksAsync()
        {
            return await _bookManager.GetAllBooksAsync();
        }
    }
}
