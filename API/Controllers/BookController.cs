﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Common.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Http;
using System.Globalization;
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

        [HttpGet("getbookbybookid/{id}")]
        public async Task<IActionResult> GetBookByBookId(int id)
        {
            var result = await _bookManager.GetBookByBookIdAsync(id);
            return Ok(result);
        }

        [HttpGet("searchvalue/{booksearchValue}")]
        public async Task<IActionResult> GetBooksBySearchValue(string searchValue)
        {
            var result = await _bookManager.GetBooksBySearchValueAsync(searchValue);
            return Ok(result);
        }

        [HttpPost("updatebook")]
        public async Task<int> UpdateBook([FromBody] Book book)
        {
            return await _bookManager.UpdateBookAsync(book);
        }

        [HttpPut("createbook/{id}")]
        public async Task<int> CreateBook(int id, [FromBody] Book book)
        {
            return await _bookManager.CreateBookAsync(book);
        }

        [HttpDelete("deletebookbybookid/{id}")]
        public async Task<int> DeleteBookByBookId(int id)
        {
            return await _bookManager.DeleteBookAsync(id);
        }
    }
}
