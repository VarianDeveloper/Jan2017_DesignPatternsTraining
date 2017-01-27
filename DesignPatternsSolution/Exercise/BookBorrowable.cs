namespace Exercise
{
    public abstract class ABookBorrowable
    {
        public virtual void BorrowOne() { }
        protected BorrowOne BorrowOneProcedure;

        public ABookBorrowable(BorrowOne borrowOneProcedure)
        {
            BorrowOneProcedure = borrowOneProcedure;
        }
    }

    public class BookBorrowable : ABookBorrowable
    {
        private ABookBorrowable _bookBorrowable;

        public BookBorrowable(ABookBorrowable bookBorrowable, BorrowOne borrowOne) : base(borrowOne)
        {
            _bookBorrowable = bookBorrowable;
        }

        public override void BorrowOne()
        {
            _bookBorrowable.BorrowOne();
        }
    }

    public class BorrowOne
    {
        private LibObject item;

        public BorrowOne(LibObject item)
        {
            item.AvailableAmount--;
        }
    }
}
