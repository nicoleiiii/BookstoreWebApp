using Microsoft.AspNetCore.Mvc;
using BookstoreWebApp.Models;

namespace BookstoreWebApp.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View(BookData.Books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            book.Id = BookData.Books.Count + 1;
            BookData.Books.Add(book);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var book = BookData.Books.Find(b => b.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            var existingBook = BookData.Books.Find(b => b.Id == book.Id);
            if (existingBook == null) return NotFound();

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Price = book.Price;
            existingBook.PublicationYear = book.PublicationYear;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var book = BookData.Books.Find(b => b.Id == id);
            if (book != null)
            {
                BookData.Books.Remove(book);
            }
            return RedirectToAction("Index");
        }
    }
}

