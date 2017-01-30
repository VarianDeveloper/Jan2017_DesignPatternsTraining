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
            var libraryInstance1 = Library.GetInstance();
            var libraryInstance2 = Library.GetInstance();

            Assert.AreSame(libraryInstance1, libraryInstance2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            var book = new Book("Jason Mark","Clean Code",1997,25);
            var response = RegistrationRepository.Register(book);

            Assert.IsTrue(response > -1);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            var customer = new Customer("Jason Mark","386 Broadway");
            var response = RegistrationRepository.Register(customer);

            Assert.IsTrue(response > -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            int bookInInventory = 25;
            var book = new Book("Jason Mark", "Clean Code", 1997, bookInInventory);
            var borrowable = new BookBorrowable(book);

            borrowable.BorrowBook();
            Assert.IsTrue(book.AvailableAmount == bookInInventory - 1);

        }       
    }
}
