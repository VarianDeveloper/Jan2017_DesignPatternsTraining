namespace Exercise
{
    /*
     * Instructions unclear. Did this.
    */
    public abstract class BookDecorator : Book
    {
        private Book _book;

        protected BookDecorator(Book book)
            : base(book.Author, book.NameOrTitle, book.YearCreated, book.AvailableAmount)
        {
            _book = book;
        }
    }

    public class BorrowableBook : BookDecorator
    {
        public BorrowableBook(Book book)
            : base(book)
        { }

        public void BorrowOne()
        {
            AvailableAmount--;
        }
    }
}
