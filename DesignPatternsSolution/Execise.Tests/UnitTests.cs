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
            var l1 = Library.GetInstance();
            var l2 = Library.GetInstance();

            Assert.AreSame(l1, l2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            int value = RegistrationRepository.Register(new Book("Author", "Title", 1997, 5));

            Assert.AreNotEqual<int>(-1, value);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            int value = RegistrationRepository.Register(new Customer("Customer Name", "Address"));

            Assert.AreNotEqual<int>(-1, value);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            var book = new Book("Author", "Title", 1997, 5);
            var borrowable = new BookBorrowable(book);

            borrowable.BorrowOne();
            Assert.AreEqual<int>(4, book.AvailableAmount);
        }       
    }
}
