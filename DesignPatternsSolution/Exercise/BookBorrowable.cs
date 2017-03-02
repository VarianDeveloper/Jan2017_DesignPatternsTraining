namespace Exercise
{
    public class BookBorrowable
    {
        private Book book;

        public BookBorrowable(Book book)
        {
            this.book = book;
        }

        public void BorrowOne()
        {
            book.AvailableAmount--;
        }

        public int AmountToBorrow()
        {
            return book.AvailableAmount;
        }
    }
}
