using System;

namespace mis221_lab7_ajstevenson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());
            Console.WriteLine();
            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());
            Console.WriteLine();
            Console.WriteLine(myBook.GetAuthor().ToString());
            Console.WriteLine();
            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            Console.WriteLine(yourBook.ToString());
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            Console.WriteLine(yourBook.ToString());
        }
    }
}
