using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookManager _bookManager;

        public BookController(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        [HttpGet]
        [Route("GetAllBooks")]
        public async Task<List<Book>> GetAllBooks()
        {
            return await _bookManager.GetAllBooksAsync();
        }

        [HttpGet("{id}")]
        public async Task<Book> GetBookByBookId(int id)
        {
            return await _bookManager.GetBookByBookIdAsync(id);
        }

        [HttpGet("{searchValue}")]
        [Route("SearchValue")]
        public async Task<List<Book>> GetBooksBySearchValue(string searchValue)
        {
            return await _bookManager.GetBooksBySearchValueAsync(searchValue);
        }

        [HttpPost]
        public async Task<int> UpdateBook([FromBody] Book book)
        {
            return await _bookManager.UpdateBookAsync(book);
        }

        [HttpPut("{id}")]
        public async Task<int> CreateBook(int id, [FromBody] Book book)
        {
            return await _bookManager.CreateBookAsync(book);
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteBook(int id)
        {
            return await _bookManager.DeleteBookAsync(id);
        }
    }
}
