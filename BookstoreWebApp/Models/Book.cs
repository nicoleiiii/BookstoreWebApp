namespace BookstoreWebApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int PublicationYear { get; set; }
    }

    public static class BookData
    {
        public static List<Book> Books = new()
        {
            new Book { Id = 1, Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", Price = 19.99m, PublicationYear = 1997 },
            new Book { Id = 2, Title = "Harry Potter and the Chamber of Secrets", Author = "J.K. Rowling", Price = 19.99m, PublicationYear = 1998 },
            new Book { Id = 3, Title = "Harry Potter and the Prisoner of Azkaban", Author = "J.K. Rowling", Price = 19.99m, PublicationYear = 1999 },
            new Book { Id = 4, Title = "Harry Potter and the Goblet of Fire", Author = "J.K. Rowling", Price = 19.99m, PublicationYear = 2000 },
            new Book { Id = 5, Title = "Harry Potter and the Order of the Phoenix", Author = "J.K. Rowling", Price = 19.99m, PublicationYear = 2003 },
            new Book { Id = 6, Title = "Harry Potter and the Half-Blood Prince", Author = "J.K. Rowling", Price = 19.99m, PublicationYear = 2005 },
            new Book { Id = 7, Title = "Harry Potter and the Deathly Hallows", Author = "J.K. Rowling", Price = 19.99m, PublicationYear = 2007 },
            new Book { Id = 8, Title = "Harry Potter and the Cursed Child", Author = "J.K. Rowling", Price = 19.99m, PublicationYear = 2016 }
        };
    }
}

