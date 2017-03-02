using ExerciseInterfaces;

namespace Exercise
{
    public class Borrowable : IBorrowable
    {
        private readonly ILibraryObject _decoratedLibraryObject;

        public Borrowable(ILibraryObject libraryObject)
        {
            _decoratedLibraryObject = libraryObject;
        }

        public new int BorrowOne()
        {
            return this.Borrow(1);
        }

        public new int Borrow(int numberOfCopiesToBorrow)
        {
            if (_decoratedLibraryObject.AvailableAmount < numberOfCopiesToBorrow)
                return 0;

            _decoratedLibraryObject.AvailableAmount -= numberOfCopiesToBorrow;
            return numberOfCopiesToBorrow;
        }
    }
}
