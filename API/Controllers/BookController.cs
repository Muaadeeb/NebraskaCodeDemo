using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ModelDTOs;

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

        [HttpGet("getallbooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                var result = await _bookManager.GetAllBooksAsync();
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "Book Controller",
                    ErrorMessage = $"GetAllBooks had an error - {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError
                });
            }
        }

        [HttpGet("getbookbybookid")]
        public async Task<IActionResult> GetBookByBookId(int bookId)
        {
            var result = await _bookManager.GetBookByBookIdAsync(bookId);
            return Ok(result);
        }
        
        [HttpGet("searchvalue")]
        public async Task<IActionResult> GetBooksBySearchValueAsync(string bookSearchValue)
        {
            var result = await _bookManager.GetBooksBySearchValueAsync(bookSearchValue);
            return Ok(result);
        }

        [HttpPost("updatebook")]
        public async Task<IActionResult> UpdateBookAsync([FromBody] Book book)
        {
            try
            {
                var result = await _bookManager.UpdateBookAsync(book);
                if (result == 0)
                {
                    return Ok(StatusCodes.Status200OK);
                }

                return BadRequest(StatusCodes.Status400BadRequest);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "Book Controller",
                    ErrorMessage = $"Update Book had an error - {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError
                });
            }
        }

        [HttpPut("createbook")]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            try
            {
                var result = await _bookManager.CreateBookAsync(book);
                if (result == 0)
                {
                    return Ok(StatusCodes.Status201Created);
                }

                return BadRequest(StatusCodes.Status400BadRequest);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "Book Controller",
                    ErrorMessage = $"Create Book had an error - {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError
                });
            }
        }

        [HttpDelete("deletebookbybookid")]
        public async Task<int> DeleteBookByBookId(int bookId)
        {
            return await _bookManager.DeleteBookAsync(bookId);
        }
    }
}
