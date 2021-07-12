using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using DataAccess.Interfaces;
using NebraskaCodeDataLibraryDemo.Data.Interfaces;

namespace DataAccess
{
	public class BookRepository : IBookRepository
    {
        private readonly IBookData _bookData;

        public BookRepository(IBookData bookData)
        {
            _bookData = bookData;
        }

        public async Task<int> CreateBookAsync(Book book)
        {
            var newBook = new NebraskaCodeDataLibraryDemo.Db.Models.Book()
            {
                BookId = book.BookId,
                Title = book.Title,
                AuthorFirstName = book.AuthorFirstName,
                AuthorLastName = book.AuthorLastName,
                AuthorMiddleName = book.AuthorMiddleName,
                CategoryId = book.CategoryId,
                SubCategoryId = book.SubCategoryId,
                PrintLength = book.PrintLength,
                Publisher = book.Publisher,
                PublicationDate = book.PublicationDate,
                ISBN = book.ISBN,
                ReviewRating = book.ReviewRating,
                CreatedUser = book.CreatedUser,
                UpdatedUser = book.UpdatedUser,
                CreatedDate = book.CreatedDate,
                UpdatedDate = book.UpdatedDate
            };

            var result = await _bookData.CreateBookAsync(newBook);
            return result;
        }

        public async Task<int> UpdateBookAsync(Book book)
        {
            var updateBook = new NebraskaCodeDataLibraryDemo.Db.Models.Book()
            {
                BookId = book.BookId,
                Title = book.Title,
                AuthorFirstName = book.AuthorFirstName,
                AuthorLastName = book.AuthorLastName,
                AuthorMiddleName = book.AuthorMiddleName,
                CategoryId = book.CategoryId,
                SubCategoryId = book.SubCategoryId,
                PrintLength = book.PrintLength,
                Publisher = book.Publisher,
                PublicationDate = book.PublicationDate,
                ISBN = book.ISBN,
                ReviewRating = book.ReviewRating,
                CreatedUser = book.CreatedUser,
                UpdatedUser = book.UpdatedUser,
                CreatedDate = book.CreatedDate,
                UpdatedDate = book.UpdatedDate
            };

            var result = await _bookData.UpdateBookAsync(updateBook);
            return result;
        }

        public async Task<int> DeleteBookAsync(int bookId)
        {
            var result = await _bookData.DeleteBookAsync(bookId);
            return result;
        }

        public async Task<List<Book>> GetBooksBySearchValueAsync(string searchValue)
        {
            var results = await _bookData.GetBooksBySearchValueAsync(searchValue);

            var book = new Book();
            var bookList = new List<Book>();

            foreach (var result in results)
            {
                book.BookId = result.BookId;
                book.Title = result.Title;
                book.AuthorFirstName = result.AuthorFirstName;
                book.AuthorMiddleName = result.AuthorMiddleName;
                book.AuthorLastName = result.AuthorLastName;
                book.CategoryId = result.CategoryId;
                book.SubCategoryId = result.SubCategoryId;
                book.PrintLength = result.PrintLength;
                book.Publisher = result.Publisher;
                book.PublicationDate = result.PublicationDate;
                book.ISBN = result.ISBN;
                book.ReviewRating = result.ReviewRating;
                book.CreatedUser = result.CreatedUser;
                book.UpdatedUser = result.UpdatedUser;
                book.CreatedDate = result.CreatedDate;
                book.UpdatedDate = book.UpdatedDate;

                bookList.Add(book);
            }

            return bookList;
        }

        public async Task<Book> GetBookByBookIdAsync(int bookId)
        {
            var result = await _bookData.GetBookByBookIdAsync(bookId);

            var book = new Book();
            book.BookId = result.BookId;
            book.Title = result.Title;
            book.AuthorFirstName = result.AuthorFirstName;
            book.AuthorMiddleName = result.AuthorMiddleName;
            book.AuthorLastName = result.AuthorLastName;
            book.CategoryId = result.CategoryId;
            book.SubCategoryId = result.SubCategoryId;
            book.PrintLength = result.PrintLength;
            book.Publisher = result.Publisher;
            book.PublicationDate = result.PublicationDate;
            book.ISBN = result.ISBN;
            book.ReviewRating = result.ReviewRating;
            book.CreatedUser = result.CreatedUser;
            book.UpdatedUser = result.UpdatedUser;
            book.CreatedDate = result.CreatedDate;
            book.UpdatedDate = book.UpdatedDate;

            return book;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            var results = await _bookData.GetAllBooksAsync();

            var book = new Book();
            var bookList = new List<Book>();

            foreach (var result in results)
            {
                book.BookId = result.BookId;
                book.Title = result.Title;
                book.AuthorFirstName = result.AuthorFirstName;
                book.AuthorMiddleName = result.AuthorMiddleName;
                book.AuthorLastName = result.AuthorLastName;
                book.CategoryId = result.CategoryId;
                book.SubCategoryId = result.SubCategoryId;
                book.PrintLength = result.PrintLength;
                book.Publisher = result.Publisher;
                book.PublicationDate = result.PublicationDate;
                book.ISBN = result.ISBN;
                book.ReviewRating = result.ReviewRating;
                book.CreatedUser = result.CreatedUser;
                book.UpdatedUser = result.UpdatedUser;
                book.CreatedDate = result.CreatedDate;
                book.UpdatedDate = book.UpdatedDate;

                bookList.Add(book);
            }

            return bookList;
        }

	}
}
