namespace task_6;

public interface ILibrary
{
    public void AddBook(Book book);
    public List<Book> DisplayBooks();
    public void UpdateBook(Book _book);
    public void DeleteBook(int id);
    public Book SearchByTitle(string title);
    public Book SearchByAuthor(string author);



}
