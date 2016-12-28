using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            MainBooks();
        }

        //Task1
        static void MainBooks()
        {
            IEnumerable<Book> books = new List<Book>()
            {
                new Book { Name = "FirstBookName", Year = 1980 },
                new Book { Name = "LINQBookName", Year = 1904 },
                new Book { Name = "ThirdBookName", Year = 2000 }
            };
            var result = books.Where(book => book.Name.Contains("LINQ") && DateTime.IsLeapYear(book.Year));
        }

        //Task2
        static void Words()
        {
            string[] arrayWords = { "Добро", "Пожаловать" };
            var result = arrayWords.SelectMany(word => word).Distinct().Count();
        }

        //Task3
        static void DoubleFigures()
        {
            int[] arrayFigures = { 14, 12, 23, 20, 33, 32 };
            arrayFigures.OrderBy(x => x);
        }
    }

    class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
}