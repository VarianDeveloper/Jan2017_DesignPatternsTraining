namespace Exercise
{
    public class BookBorrowable
    {
        private Book book;
        private int numberOfBooks = 0;
        public BookBorrowable(Book b, int amount)
        {
            book = b;
            numberOfBooks = amount;
        }

        public Book borrowOne()
        {

            numberOfBooks--;
            return book;
        }
        public int numberOfBooksLeft()
        {
            return numberOfBooks;
        }
    }
}
