namespace task_6;

public class Library : ILibrary
{
    List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public List<Book> DisplayBooks()
    {
        return books;
    }
    public void UpdateBook(Book _book)
    {
        var book = books.FirstOrDefault(e => e.Id == _book.Id);
        books.Add(book);
        books.Remove(book);
    }
    public void DeleteBook(int id)
    {
        var book = books.FirstOrDefault(e => e.Id == id);
        books.Remove(book);
    }
    public Book SearchByTitle(string title)
    {
        var book = books.FirstOrDefault(e => e.Title == title);
        return book;
    }
    public Book SearchByAuthor(string author)
    {
        var book = books.FirstOrDefault(e => e.Author == author);
        return book;
    }


}
