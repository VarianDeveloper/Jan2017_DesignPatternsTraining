namespace Exercise_Answers
{
    public class BookBorrowable : Book
    {
        private readonly Book _book;

        public new string Author
        {
            get { return _book.Author; }
            set { _book.Author = value; }
        }

        public new int AvailableAmount
        {
            get { return _book.AvailableAmount; }
            set { _book.AvailableAmount = value; }
        }

        public bool BorrowOne()
        {
            if (_book.AvailableAmount <= 0) return false;

            _book.AvailableAmount--;
            return true;
        }

        public BookBorrowable(Book b) : base(b.Author, b.NameOrTitle, b.YearCreated, b.AvailableAmount)
        {
            _book = b;
        }
    }
}
