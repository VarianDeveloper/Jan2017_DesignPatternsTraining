namespace Exercise
{
    public class BookBorrowable : Book
    {
       private Book Book { get; set; }

        public BookBorrowable(Book bookToBorrow) : base(bookToBorrow.Author, bookToBorrow.NameOrTitle, bookToBorrow.YearCreated, bookToBorrow.YearCreated)
        {
            this.Book = bookToBorrow;
        }

        public bool BorrowOne()
        {
            if (this.Book.AvailableAmount > 0)
            {
                this.Book.AvailableAmount--;
                return true;
            }
            else
                return false;
                
        }
    }
}
