using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorWebAssemblyClient.Services.Interfaces;
using ModelDTOs;
using System.Net.Http;
using Newtonsoft.Json;


namespace BlazorWebAssemblyClient.Services
{
    public class BookService : IBookService
    {
        private readonly HttpClient _httpClient;

        //public async Task<int> CreateBookAsync(BookDTO book)
        //{

        //    var result = await _bookRepository.CreateBookAsync(book);
        //    return result;
        //}

        //public async Task<int> UpdateBookAsync(BookDTO book)
        //{

        //    var result = await _bookRepository.UpdateBookAsync(book);
        //    return result;
        //}

        //public async Task<int> DeleteBookAsync(int bookId)
        //{
        //    var result = await _bookRepository.DeleteBookAsync(bookId);
        //    return result;
        //}

        //public async Task<List<BookDTO>> GetBooksBySearchValueAsync(string searchValue)
        //{
        //    var results = await _bookRepository.GetBooksBySearchValueAsync(searchValue);

        //    return results;
        //}

        //public async Task<BookDTO> GetBookByBookIdAsync(int bookId)
        //{
        //    var result = await _bookRepository.GetBookByBookIdAsync(bookId);

        //    return result;
        //}

        public async Task<List<BookDTO>> GetAllBooksAsync()
        {
            var results = await _httpClient.GetAsync($"api/GetAllBooks");
            var content = await results.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<BookDTO>>(content);
        }

    }
}
