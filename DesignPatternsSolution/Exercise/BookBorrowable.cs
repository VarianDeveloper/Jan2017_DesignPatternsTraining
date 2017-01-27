namespace Exercise
{
    public abstract class Borrowable
    {
        public virtual void BorrowOne() {}

        protected LibObject LibObject;
        public Borrowable(LibObject libObject)
        {
            LibObject = libObject;
        }
    }

    public class BookBorrowable : Borrowable
    {
        private Borrowable borrowable;

        public BookBorrowable(Borrowable borrowable, Book book)
            : base(book)
        {
            this.borrowable = borrowable;
        }

        public override void BorrowOne()
        {
            if (borrowable != null)
            {
                borrowable.BorrowOne();
            }

            if (LibObject.AvailableAmount > 0)
            {
                LibObject.AvailableAmount--;
            }
            else
            {
                throw new System.Exception("No books left to borrow.");
            }
        }
    }
}
