namespace Exercise
{
    public class BookBorrowable : Book
    {
        private Book thing;
        private Decorator decorator;

        public BookBorrowable(Book book, Decorator decorator) :
            base(book.Author, book.NameOrTitle, book.YearCreated, book.AvailableAmount)
        {
            thing = book;
            this.decorator = decorator;
        }

        public void Borrow()
        {
            decorator.Borrow(thing);
        }
    }

    public class Decorator
    {
        public void Borrow(Book x)
        {
            x.AvailableAmount--;
        }
    }
}
