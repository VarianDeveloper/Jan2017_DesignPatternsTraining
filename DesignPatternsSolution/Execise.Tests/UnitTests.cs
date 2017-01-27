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
            Assert.AreEqual(Library.getInstance(), Library.getInstance());
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Library library = Library.getInstance();

            Book book = new Book("author", "title", 1950, 2, new LibObjectRegistrationInfoAPI());

            Assert.AreNotEqual(-1, library.Register(book));
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Library library = Library.getInstance();

            Customer customer = new Customer("name", "address", new LibObjectRegistrationInfoAPI());

            Assert.AreNotEqual(-1, library.Register(customer));
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            Library library = Library.getInstance();

            Book book = new Book("author", "title", 1950, 2, new LibObjectRegistrationInfoAPI());
            BookBorrowable borrowable = new BookBorrowable(null, book);

            borrowable.BorrowOne();

            Assert.AreEqual(1, book.AvailableAmount);
        }       
    }
}
