using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPorject.Models;

namespace WebPorject.Repository
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
            return new List<BookModel>()
            {
                new BookModel(){Id =1, Title="MVC",Author="belal 1"},
                new BookModel(){Id =2, Title="C#",Author="belal 2"},
                new BookModel(){Id =3, Title="PHP",Author="belal 3"},
                new BookModel(){Id =4, Title="Java",Author="belal 4"},
            };
        }

    }
}
