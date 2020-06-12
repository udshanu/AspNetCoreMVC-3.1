﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdShanu.BookStore.Models;

namespace UdShanu.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel(){Id = 1, Title = "C#", Author = "Roshan" },
                new BookModel(){Id = 2, Title = "Java", Author = "Manoj" },
                new BookModel(){Id = 3, Title = "PHP", Author = "Gunarathna" },
                new BookModel(){Id = 4, Title = "Angular", Author = "Shanu" },
                new BookModel(){Id = 5, Title = "React", Author = "mano" }
            };
        }
    }
}
