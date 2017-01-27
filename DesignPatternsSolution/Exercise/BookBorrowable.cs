namespace Exercise
{
    public class BookBorrowable 
    {
        private readonly Book _book;

        public BookBorrowable(Book book)
        {
            _book = book;
        }

        public void BorrowOne()
        {
            _book.AvailableAmount--;
        }
    }
}
