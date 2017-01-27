using Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Execise.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void LibraryShouldBeSingleton()
        {
            var library1 = Library.GetInstance();
            var library2 = Library.GetInstance();

            Assert.AreEqual(library1, library2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            var book = new Book("The Author", "The Book", 2001, 25);

            var library = Library.GetInstance();

            var registrationResult = library.Register(book);

            Assert.AreNotEqual(-1, registrationResult);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            var customer = new Customer("Fred", "123 Place St.");

            var library = Library.GetInstance();

            var registrationResult = library.Register(customer);

            Assert.AreNotEqual(-1, registrationResult);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            
            var book = new Book("Mr. Cat", "Supertown", 2009, 7);

            var borrowableBook = new BorrowableBook(book);

            borrowableBook.BorrowOne();

            Assert.AreEqual(6, borrowableBook.AvailableAmount);
        }       
    }
}
