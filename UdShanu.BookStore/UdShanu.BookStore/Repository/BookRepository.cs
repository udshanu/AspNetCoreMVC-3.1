using System;
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
                new BookModel(){Id = 1, Title = "MVC", Author = "Roshan", Description = "This is the description of MVC book.", Category = "Programming", Language = "English", TotalPages = 134},
                new BookModel(){Id = 2, Title = "Dot Net Core", Author = "Manoj", Description = "This is the description of Dot Net Core book.", Category = "Framework", Language = "Chinese", TotalPages = 567 },
                new BookModel(){Id = 3, Title = "C#", Author = "Gunarathna", Description = "This is the description of C# book.", Category = "Developer", Language = "Hindi", TotalPages = 897 },
                new BookModel(){Id = 4, Title = "Java", Author = "Shanu", Description = "This is the description of Java book.", Category = "Concept", Language = "English", TotalPages = 564 },
                new BookModel(){Id = 5, Title = "PHP", Author = "mano", Description = "This is the description of Php book.", Category = "Programming", Language = "English", TotalPages = 100 },
                new BookModel(){Id = 6, Title = "Azure Devops", Author = "ud", Description = "This is the description of Azure Devops book.", Category = "Devops", Language = "English", TotalPages = 800 }
            };
        }
    }
}
