namespace Exercise
{
    public class BookBorrowable : Book
    {
        public Book _book { get; private set; }

        public BookBorrowable(Book book, string author, string title, int year, int amount) : base(author, title, year, amount)
        {
            _book = book;
        }

        public void BorrowOne()
        {
            if (_book.AvailableAmount > 0)
            {
                _book.AvailableAmount--;
            }
            else
            {
                _book.AvailableAmount = -1;
            }
        }
    }
}
