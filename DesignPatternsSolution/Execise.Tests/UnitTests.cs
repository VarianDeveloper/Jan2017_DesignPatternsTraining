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
            var first = Library.getLibrary();
            var second = Library.getLibrary();

            Assert.AreEqual(first, second);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            int x = RegistrationRepository.Register(new Book("Bakul", "No title", 2015, 19));

            Assert.AreNotEqual(-1, x);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            int x = RegistrationRepository.Register(new Customer("Bakul", "320 street not available"));
            Assert.AreNotEqual(-1, x);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            Book b = new Book("Bakul", "No title", 2015, 200);
            BookBorrowable bb = new BookBorrowable(b, new Decorator());
            bb.Borrow();
            Assert.AreNotEqual(200, b.AvailableAmount);
        }       
    }
}
