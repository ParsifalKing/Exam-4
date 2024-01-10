
using System.Net.WebSockets;
using task_6;

try
{
    var book = new Book();

    var library = new Library();
    bool exit = true;

    while (exit)
    {
        System.Console.WriteLine("Enter command add, show, update, delete, searchByTitle, searchByAuthor");
        string command = System.Console.ReadLine();

        if (command == "add")
        {
            System.Console.Write("Enter ID :");
            book.Id = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter title : ");
            book.Title = System.Console.ReadLine();
            System.Console.WriteLine("Enter author : ");
            book.Author = System.Console.ReadLine();
            library.AddBook(book);
        }
        if (command == "show")
        {
            foreach (var item in library.DisplayBooks())
            {
                System.Console.WriteLine(item.Id);
                System.Console.WriteLine(item.Title);
                System.Console.WriteLine(item.Author);
            }
        }
        if (command == "update")
        {
            System.Console.Write("Enter ID :");
            book.Id = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter title : ");
            book.Title = System.Console.ReadLine();
            System.Console.WriteLine("Enter author : ");
            book.Author = System.Console.ReadLine();
            library.UpdateBook(book);
        }
        if (command == "delete")
        {
            System.Console.Write("enter id : ");
            int id = Convert.ToInt32(System.Console.ReadLine());
            library.DeleteBook(id);
        }
        if (command == "searchByTitle")
        {
            System.Console.WriteLine("Enter title : ");
            Book search = library.SearchByTitle(System.Console.ReadLine());
            System.Console.WriteLine(search.Id);
            Console.WriteLine(search.Title);
            System.Console.WriteLine(search.Author);
        }
        if (command == "searchByAuthor")
        {
            System.Console.WriteLine("Enter author : ");
            Book search1 = library.SearchByAuthor(System.Console.ReadLine());
            System.Console.WriteLine(search1.Id);
            Console.WriteLine(search1.Title);
            System.Console.WriteLine(search1.Author);
        }

        if (command == "exit")
        {
            exit = false;
        }



    }
}
catch (System.Exception)
{
    System.Console.WriteLine("khato kadi");
}


