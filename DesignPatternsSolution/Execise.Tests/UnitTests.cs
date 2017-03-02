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
            Library lib1 = Library.getLib();
            Library lib2 = Library.getLib();
            Assert.ReferenceEquals(lib1, lib2);
            //check that when you create a Library instance second time, 
            //you get exactly the same instance as for a very first time
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Book book = new Book("Gary", "Program coding", 2017, 1, new Exercise.RegistrationApi());
            Assert.AreNotEqual(-1, RegistrationRepository.Register(book));
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Customer customer = new Customer("Gagandeep", "Winnipeg", new Exercise.RegistrationApi());
            Assert.AreNotEqual(-1, RegistrationRepository.Register(customer));
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            Book book1 = new Book("Gary2", "Program coding", 2017, 200, new Exercise.RegistrationApi());
            BookBorrowable bookborrow = new BookBorrowable(book1, new Decorator());

            bookborrow.Borrow();
            Assert.AreEqual(199, book1.AvailableAmount);

            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.

        }
    }
}
