using System;

namespace Exercise
{
    public class BookBorrowable
    {
        public Book BookToBeBorrowed { get; set; }

        public BookBorrowable(Book book)
        {
            BookToBeBorrowed = book;
        }

        public void BorrowOne()
        {
            if (BookToBeBorrowed.AvailableAmount > 0)
            {
                BookToBeBorrowed.AvailableAmount--;
            }
            else
            {
                Console.WriteLine("No amount left to borrow for this book: " + BookToBeBorrowed.NameOrTitle);
            }
        }
       
    }
}
