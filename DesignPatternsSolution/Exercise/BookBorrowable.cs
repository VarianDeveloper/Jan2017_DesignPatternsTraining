namespace Exercise
{
    public abstract class Borrowable
    {
        abstract public void BorrowOne();
    }

    public class BookBorrowable : Borrowable
    {
        private Book _book;
        private Borrowable _borrowable;

        public BookBorrowable(Borrowable borrowable, Book book)
        {
            this._borrowable = borrowable;
            this._book = book;
        }

        override public void BorrowOne()
        {
            // note that this is not decorating a "book", but a "Borrowable"
            if(_borrowable != null)
            {
                _borrowable.BorrowOne();
            }

            if (this._book.AvailableAmount > 0)
            {
                this._book.AvailableAmount--;
            }
        }
    }
}
