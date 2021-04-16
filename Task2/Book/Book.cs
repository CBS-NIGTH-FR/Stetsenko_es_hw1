using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Book
{
    class Book
    {
        Title title = null;
        Content content = null;
        Author footer = null;

        void InitializeDocument()
        {
            this.title = new Title();
            this.content = new Content();
            this.footer = new Author();
        }

        public Book(string title)
        {
            InitializeDocument();
            this.title.Content = title;
        }

        public void Show()
        {
            this.title.Show();
            this.content.Show();
            this.footer.Show();
        }

        public string Body
        {
            set
            {
                this.content.Body = value;
            }
        }

        public string Author
        {
            set
            {
                this.footer.Content = value;
            }
        }
    }
}
