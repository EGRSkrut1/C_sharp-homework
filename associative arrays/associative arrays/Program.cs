public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Id { get; set; }
}
public class Library
{
    private Dictionary<int, Book> books = new Dictionary<int, Book>();
    public void Add_book(Book book)
    {
        if (!books.ContainsKey(book.Id)) { books.Add(book.Id, book); Console.WriteLine($"Book '{book.Title}' added."); }
        else Console.WriteLine($"Book with ID {book.Id} already exists.");
    }

    public void Remove_book(int id)
    {
        if (books.ContainsKey(id)) { Console.WriteLine($"Book '{books[id].Title}' removed."); books.Remove(id); }
        else Console.WriteLine($"Book with ID {id} not found.");
    }

    public Book Find_book(int id) => books.ContainsKey(id) ? books[id] : null;

    public void List_books()
    {
        if (books.Count == 0) { Console.WriteLine("Library is empty."); return; }
        Console.WriteLine("Books in the library:");
        foreach (var book in books.Values)
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
    }
}
public class Program
{
    public static void Main()
    {
        Library library = new Library();
        Book book1 = new Book { Id = 1, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", Year = 1954 };
        Book book2 = new Book { Id = 2, Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813 };
        library.Add_book(book1);
        library.Add_book(book2);
        library.List_books();
        Book foundBook = library.Find_book(1);
        if (foundBook != null)
            Console.WriteLine($"Found Book: {foundBook.Title} by {foundBook.Author}");
        else Console.WriteLine("Book not found.");
        library.Remove_book(2);
        library.List_books();
    }
}