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
            Library lib1 = Library.GetLibrary();
            Library lib2 = Library.GetLibrary();
            Assert.AreSame(lib1, lib2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Library lib = Library.GetLibrary();
            Book book = new Book("author", "title", 2017, 10);
            Assert.AreNotEqual(lib.Register(book), -1);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Library lib = Library.GetLibrary();
            Customer customer = new Customer("name", "addr");
            Assert.AreNotEqual(lib.Register(customer), -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            Book book = new Book("author", "title", 2017, 10);
            int old = book.AvailableAmount;

            BookBorrowable bookBorrowable = new BookBorrowable(null, new BorrowOne(book));
            
            Assert.AreEqual(old - 1, book.AvailableAmount);
        }       
    }
}
