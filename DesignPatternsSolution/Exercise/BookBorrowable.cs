namespace Exercise
{
    public class BookBorrowable : Book
    {
        private Book Book { get; set; }

        public BookBorrowable(Book canBorrow) : base(canBorrow.Author, canBorrow.NameOrTitle, canBorrow.YearCreated, canBorrow.AvailableAmount)
        {
            Book = canBorrow;
        }

        public bool BorrowBook()
        {
            if (Book.AvailableAmount > 0)
            {
                Book.AvailableAmount--;
                return true;
            }

            return false;
        }
    }
}
