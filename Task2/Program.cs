using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Task2.Book.Book book = new Task2.Book.Book("Название");
            book.Body = "бла бла бла";
            book.Author = "Иванов И.И.";

            book.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
