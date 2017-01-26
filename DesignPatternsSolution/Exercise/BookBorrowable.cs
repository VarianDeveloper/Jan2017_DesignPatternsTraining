namespace Exercise
{
    public abstract class ABorrowable
    {
        public virtual void BorrowOne() { }
        protected BorrowOne borrowOneProcedure;
        public ABorrowable(BorrowOne borrowOneProcedure)
        {
            this.borrowOneProcedure = borrowOneProcedure;
        }
    }

    public class Borrowable : ABorrowable
    {
        private ABorrowable borrowableToExtend;

        public Borrowable(ABorrowable borrowable, BorrowOne borrowOneProcedure)
            : base(borrowOneProcedure)
        {
            borrowableToExtend = borrowable;
        }

        public override void BorrowOne()
        {
            if (borrowableToExtend != null)
            {
                borrowableToExtend.BorrowOne();
            }

            borrowOneProcedure.borrowOne();
        }
    }

    public class BorrowOne
    {
        private LibObject libObject;

        public BorrowOne(LibObject libObject)
        {
            this.libObject = libObject;
        }

        public void borrowOne()
        {
            this.libObject.AvailableAmount--;
        }
    }
}
