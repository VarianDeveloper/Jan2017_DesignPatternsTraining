namespace Exercise
{
    public class BookBorrowable : Book
    {
        private Book book;
        private Decorator decorator;

        public BookBorrowable(Book book, Decorator decorator)
            : base(book.Author, book.NameOrTitle, book.YearCreated, book.AvailableAmount, new Exercise.RegistrationApi())
        {
            this.book = book;
            this.decorator = decorator;
        }

        public void Borrow()
        {
            decorator.Borrow(book);
        }
    }

    public class Decorator
    {
        public void Borrow(Book book)
        {
            book.AvailableAmount--;
        }
    }
}
