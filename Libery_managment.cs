using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; } = true;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class Library
{
    private ListBook books = new ListBook();

    public void AddBook(string title, string author)
    {
        books.Add(new Book(title, author));
        Console.WriteLine(Book added successfully.);
    }

    public void ViewBooks()
    {
        Console.WriteLine(Available Books);
        foreach (var book in books)
        {
            if (book.IsAvailable)
                Console.WriteLine($Title {book.Title}, Author {book.Author});
        }
    }

    public void IssueBook(string title)
    {
        Book book = books.Find(b = b.Title == title && b.IsAvailable);
        if (book != null)
        {
            book.IsAvailable = false;
            Console.WriteLine(Book issued successfully.);
        }
        else
        {
            Console.WriteLine(Book not available.);
        }
    }

    public void ReturnBook(string title)
    {
        Book book = books.Find(b = b.Title == title && !b.IsAvailable);
        if (book != null)
        {
            book.IsAvailable = true;
            Console.WriteLine(Book returned successfully.);
        }
        else
        {
            Console.WriteLine(Book not found or already available.);
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        while (true)
        {
            Console.WriteLine(nLibrary Management System);
            Console.WriteLine(1. Add Book);
            Console.WriteLine(2. View Books);
            Console.WriteLine(3. Issue Book);
            Console.WriteLine(4. Return Book);
            Console.WriteLine(5. Exit);
            Console.Write(Enter your choice );
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1
                    Console.Write(Enter Book Title );
                    string title = Console.ReadLine();
                    Console.Write(Enter Book Author );
                    string author = Console.ReadLine();
                    library.AddBook(title, author);
                    break;
                case 2
                    library.ViewBooks();
                    break;
                case 3
                    Console.Write(Enter Book Title to Issue );
                    title = Console.ReadLine();
                    library.IssueBook(title);
                    break;
                case 4
                    Console.Write(Enter Book Title to Return );
                    title = Console.ReadLine();
                    library.ReturnBook(title);
                    break;
                case 5
                    return;
                default
                    Console.WriteLine(Invalid choice. Please try again.);
                    break;
            }
        }
    }
}
