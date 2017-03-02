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
            var library1 = Library.getInstance();
            var library2 = Library.getInstance();
            Assert.AreEqual(library1, library2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            var book = new Book("J.D. Salinger", "The Catcher in the Rye", 1951, 13);
            var bookId = RegistrationRepository.Register(book);
            Assert.IsFalse(bookId == -1);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            var customer = new Customer("Jason Wood", "386 Broadway");
            var customerId = RegistrationRepository.Register(customer);
            Assert.IsFalse(customerId == -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            const int bookAmount = 13;
            var book = new Book("J.D. Salinger", "The Catcher in the Rye", 1951, bookAmount);
            var bookBorrowable = new BookBorrowable(book, book.Author, book.NameOrTitle, book.YearCreated, book.AvailableAmount);
            bookBorrowable.BorrowOne();
            Assert.IsTrue(bookBorrowable._book.AvailableAmount == bookAmount - 1);
        }       
    }
}
