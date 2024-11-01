using System;
namespace homework2
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;
        public bool isCheckedOut;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.pages = 100;
            this.isCheckedOut = false;
        }

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.isCheckedOut = false;
        }

        public void CheckOut()
        {
            isCheckedOut = true;
        }

        public void ReturnBook()
        {
            isCheckedOut = false;
        }

        public override string ToString()
        {
            string checkedOutStatus = isCheckedOut ? "Yes" : "No";
            return $"Title: {title}, Author: {author}, Pages: {pages}, Checked Out: {checkedOutStatus}";
        }
    }
}
