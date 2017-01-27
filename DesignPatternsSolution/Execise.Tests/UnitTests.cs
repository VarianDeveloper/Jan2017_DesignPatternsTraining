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
            var lib = Library.getInstance();
            var rib = Library.getInstance();

            Assert.AreEqual<Library>(lib, rib);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Book b = new Book("Guy", "title", 1990, 100);
            var lib = Library.getInstance();

            Assert.AreNotEqual(lib.Register(b), -1);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Customer c = new Customer("Guy", "777 Broadway Ave");
            var lib = Library.getInstance();
            Assert.AreNotEqual(lib.Register(c), -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            Book b = new Book("Guy", "title", 1990, 100);
            BookBorrowable bb = new BookBorrowable(b, 10);
            var x = bb.borrowOne();
            Assert.AreEqual(bb.numberOfBooksLeft(), 9);

        }
    }
}
