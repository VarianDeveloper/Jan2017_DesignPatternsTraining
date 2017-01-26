namespace Exercise
{
    public class BookBorrowable: Book
    {
        private Book item;
        private BookDecorator decorator;

        public BookBorrowable(Book item, BookDecorator decorator) :
            base(item.Author, item.NameOrTitle, item.YearCreated, item.AvailableAmount)
        {
            this.item = item;
            this.decorator = decorator;
        }

        public void BorrowOne()
        {
            decorator.BorrowOne(item);
        }
    }

    public class BookDecorator
    {
        public void BorrowOne(Item item)
        {
            item.AvailableAmount--;
        }
    }
}
