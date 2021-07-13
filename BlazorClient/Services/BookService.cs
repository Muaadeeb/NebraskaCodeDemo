using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorClient.Services.Interfaces;
using ModelDTOs;
using Newtonsoft.Json;

namespace BlazorClient.Services
{
    public class BookService : IBookService
    {
        private readonly HttpClient _httpClient;

        public BookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

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

        public async Task<IEnumerable<BookDTO>> GetAllBooksAsync()
        {
            try
            {
                var results = await _httpClient.GetAsync("/api/book/getallbooks");
                                                        


                var contentResults = results.Content.ToString();

                if (string.IsNullOrEmpty(results.Content.ToString()))
                {
                    return default;
                }

                var content = await results.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<BookDTO>>(content);
            }
            catch (Exception ex)
            {
                throw new Exception("Something bad happened here: " + ex.Message);
            }
            
        }

    }
}
