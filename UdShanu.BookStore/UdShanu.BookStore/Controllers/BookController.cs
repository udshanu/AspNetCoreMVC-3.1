using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UdShanu.BookStore.Models;
using UdShanu.BookStore.Repository;

namespace UdShanu.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        //public List<BookModel> GetAllBooks()
        public ViewResult GetAllBooks()
        {
            //return _bookRepository.GetAllBooks();
            var data = _bookRepository.GetAllBooks();

            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }

    }
}