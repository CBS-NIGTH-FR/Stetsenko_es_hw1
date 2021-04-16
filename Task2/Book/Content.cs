using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Book
{
    class Content
    {
        string body;

        public string Body
        {
            private get
            {
                if (body != null)
                    return body;
                else
                    return "Контент отсутствует.";
            }
            set
            {
                body = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Body);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
