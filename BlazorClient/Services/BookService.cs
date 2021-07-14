using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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

        public async Task<int> CreateBookAsync(BookDTO book)
        {
            var id = 1;
            JsonContent content = JsonContent.Create(book);
            HttpResponseMessage response = await _httpClient.PostAsync($"/api/book/createbook/{id}", content);
            return 0;
        }

        public async Task<int> UpdateBookAsync(BookDTO book)
        {
            JsonContent content = JsonContent.Create(book);
            HttpResponseMessage response = await _httpClient.PostAsync($"/api/book/updatebook/{book}", content);
            return 0;
        }

        public async Task<int> DeleteBookAsync(int bookId)
        {
            var response = await _httpClient.DeleteAsync($"deletebookbybookid/{bookId}");
            return 0;
        }

        public async Task<IEnumerable<BookDTO>> GetBooksBySearchValueAsync(string bookSearchValue)
        {
            var response = await _httpClient.GetAsync($"/api/book/searchvalue/{bookSearchValue}");
            return await BookMapping(response);
        }

        public async Task<IEnumerable<BookDTO>> GetBookByBookIdAsync(int bookId)
        {
            var response = await _httpClient.GetAsync("/api/book/getbookbybookid");
            return await BookMapping(response);
        }

        public async Task<IEnumerable<BookDTO>> GetAllBooksAsync()
        {
            var response = await _httpClient.GetAsync("/api/book/getallbooks");
            return await BookMapping(response);
        }

        private async Task<IEnumerable<BookDTO>> BookMapping(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<BookDTO>>(content);
        }
    }
}
