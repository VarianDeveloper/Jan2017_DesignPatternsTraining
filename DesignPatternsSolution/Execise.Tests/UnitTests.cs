using Exercise;
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
            Assert.IsTrue(Library.getInstance() == Library.getInstance());
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            var book = new Book("George Orwell", "1984", 1934, 5);
            RegistrationRepository.Register(book);
            Assert.IsFalse(book.ObjectId == -1);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            var customer = new Customer("George Orwell", "19 Eightyfour Lane");
            RegistrationRepository.Register(customer);
            Assert.IsFalse(customer.ObjectId == -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one.
            var borrowableBook = new BookBorrowable(new Book("Isaac Asimov", "Foundation", 1974, 4));
            int initialAmount = borrowableBook.BookToBeBorrowed.AvailableAmount;
            borrowableBook.BorrowOne();
            int afterBorrowedAmount = borrowableBook.BookToBeBorrowed.AvailableAmount;
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            Assert.IsTrue(afterBorrowedAmount == (initialAmount - 1));
        }       
    }
}
