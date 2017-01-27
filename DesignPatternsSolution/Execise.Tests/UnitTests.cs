using Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise.Tests
{
    [TestClass]
    public class UnitTests
    {
        //test the two calls to library instance return same instance
        [TestMethod]
        public void LibraryShouldBeSingleton()
        {
            Library libraryInstance1 = Library.GetInstance();
            Library libraryInstance2 = Library.GetInstance();

            Assert.AreEqual(libraryInstance1, libraryInstance2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Book book = new Book("Cash Craig", "Fake Book", 1991, 7);
            int result = RegistrationRepository.Register(book);
            Assert.AreNotEqual(-1, result);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Customer customer = new Customer("Cash Craig", "123 Fake Street");
            int result = RegistrationRepository.Register(customer);
            Assert.AreNotEqual(-1, result);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            Book myBook = new Book("Cash Craig", "Fake Book", 1991, 7);

            int oldCount = myBook.AvailableAmount;

            Borrowable bookBorrowable = new Borrowable(null, new Borrow(myBook));
            bookBorrowable.BorrowOne();

            int newCount = myBook.AvailableAmount;

            Assert.AreEqual(oldCount - 1, newCount);
        }       
    }
}
