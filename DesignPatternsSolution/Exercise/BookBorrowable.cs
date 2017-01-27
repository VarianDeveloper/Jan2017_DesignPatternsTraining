namespace Exercise
{
    public abstract class ABorrowable 
    {
        public virtual void BorrowOne() { }
        protected Borrow Borrow;

        protected ABorrowable(Borrow borrow)
        {
            this.Borrow = borrow;
        }
    }

    public class Borrowable : ABorrowable
    {
        private readonly ABorrowable _borrowable;

        public Borrowable(ABorrowable borrowable, Borrow borrow) : base(borrow)
        {
            _borrowable = borrowable;
        }

        public override void BorrowOne()
        {
            if (_borrowable != null)
            {
                _borrowable.BorrowOne();
            }

            Borrow.BorrowOne();
        }
    }

    public class Borrow
    {
        private readonly LibObject _libObject;

        public Borrow(LibObject libObject)
        {
            this._libObject = libObject;
        }

        public void BorrowOne()
        {
            this._libObject.AvailableAmount--;
        }
    }
}
