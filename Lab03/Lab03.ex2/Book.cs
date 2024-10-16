using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.ex2
{
    internal class Book
    {
        private string author;
        private int pages;
        private string isbn;
        private string title;
        private int currentpage;
        public Book()
        {
            author = "";
            pages = 0;
            isbn = "";
            title = "";
            currentpage = 1;
        }
        public Book(string author,  int pages, string isbn, string title, int currentpage)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
        }
        public void Display()
        {
            Console.WriteLine("tác giả: " + author);
            Console.WriteLine("trang: " + pages);
            Console.WriteLine("isbn" + isbn);
            Console.WriteLine("Tiêu đề: " + title);
            Console.WriteLine("Trang hiện tại: " + currentpage);
        }
        public void flipPageForWard()
        {
            Console.WriteLine("Lật sang trang trước!");
        }
        public void flipPagesBackward()
        {
            Console.WriteLine("Lật sang trang sau");
        }
    }
}
