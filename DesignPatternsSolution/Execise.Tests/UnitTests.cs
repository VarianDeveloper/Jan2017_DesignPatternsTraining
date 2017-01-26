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
            var firstInstanceLibrary = Library.getLibrary();
            var secondInstanceLibrary = Library.getLibrary();

            Assert.AreSame(firstInstanceLibrary, secondInstanceLibrary);

        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            var library = Library.getLibrary();
            var value = library.Register(new Book("Bob", "The Book", 1922, 10));
            Assert.AreNotEqual(-1, value);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            var library = Library.getLibrary();
            var value = library.Register(new Customer("bob", "200 street"));
            Assert.AreNotEqual(-1, value);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            var books = new BookBorrowable("bob", "The book", 1822, 8);
            books.BorrowOne();
            Assert.AreEqual(7, books.getAvailableAmount());
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            
        }       
    }
}
