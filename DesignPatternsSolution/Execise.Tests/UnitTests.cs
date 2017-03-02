using System.Linq.Expressions;
using Exercise;
using ExerciseInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Execise.Tests
{
    [TestClass]
    public class UnitTests
    {
        //test the two calls to library instance return same instance
        [TestMethod]
        public void LibraryShouldBeSingleton()
        {
            //check that when you create a Library instance second time, 
            //you get exactly the same instance as for a very first time
            Library lib1 = Library.Instance();
            Library lib2 = Library.Instance();

            Assert.AreSame(lib1, lib2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            int returnVal = Library.Instance().Register(new Book("Daryl Haase","Memoirs of Daryl", 2001, 4));

            Assert.IsFalse(returnVal==-1);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            int returnVal = Library.Instance().Register(new Customer("Daryl Haase","123 Street"));

            Assert.IsFalse(returnVal == -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook_OneOfThreeAvailable()
        {
            int quantity = 3;
            int numberToBorrow = 1;
            int numberBorrowed = 0;

            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the Borrowable instance. Check that total amount was reduced by one.
            ILibraryObject chickenLittle = new Book("Dunno ThinkItsAFable", "Chicken Little", 1910, quantity);
            Borrowable chickenLittleBorrowable = new Borrowable(chickenLittle);

            numberBorrowed = chickenLittleBorrowable.BorrowOne();

            Assert.AreEqual(numberBorrowed, numberToBorrow);
            Assert.AreEqual(chickenLittle.AvailableAmount, quantity - numberToBorrow);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook_TwoOfThreeAvailable()
        {
            int quantity = 3;
            int numberToBorrow = 2;
            int numberBorrowed = 0;

            ILibraryObject chickenLittle = new Book("Dunno ThinkItsAFable", "Chicken Little", 1910, quantity);
            Borrowable chickenLittleBorrowable = new Borrowable(chickenLittle);

            numberBorrowed = chickenLittleBorrowable.Borrow(numberToBorrow);

            Assert.AreEqual(numberBorrowed, numberToBorrow);
            Assert.AreEqual(chickenLittle.AvailableAmount, quantity - numberToBorrow);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook_ThreeOfThreeAvailable()
        {
            int quantity = 3;
            int numberToBorrow = 3;
            int numberBorrowed = 0;

            ILibraryObject chickenLittle = new Book("Dunno ThinkItsAFable", "Chicken Little", 1910, quantity);
            Borrowable chickenLittleBorrowable = new Borrowable(chickenLittle);

            numberBorrowed = chickenLittleBorrowable.Borrow(numberToBorrow);

            Assert.AreEqual(numberBorrowed, numberToBorrow);
            Assert.AreEqual(chickenLittle.AvailableAmount, quantity - numberToBorrow);
        }

        //test that we cannot borrow more books than the library has copies
        [TestMethod]
        public void CanBorrowBook_FourOfThreeAvailable()
        {
            int quantity = 3;
            int numberToBorrow = 4;
            int numberBorrowed = 0;

            ILibraryObject chickenLittle = new Book("Dunno ThinkItsAFable", "Chicken Little", 1910, quantity);
            Borrowable chickenLittleBorrowable = new Borrowable(chickenLittle);

            numberBorrowed = chickenLittleBorrowable.Borrow(numberToBorrow);

            Assert.AreEqual(numberBorrowed, 0);
            Assert.AreEqual(chickenLittle.AvailableAmount, quantity);
        }
    }
}
