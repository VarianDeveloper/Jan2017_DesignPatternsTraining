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
            //check that when you create a Library instance second time, 
            //you get exactly the same instance as for a very first time
            Library library1 = Library.getInstance();
            Library library2 = Library.getInstance();

            Assert.AreEqual(library1, library2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Book book = new Book("Mr. Smart", "My Book", 1985, 20);
            int result = RegistrationRepository.Register(book);
            Assert.AreNotEqual(-1, result);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Customer customer = new Customer("John Doe", "123 Fourth St.");
            int result = RegistrationRepository.Register(customer);
            Assert.AreNotEqual(-1, result);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.

            Book myBook = new Book("Glen Miller", "My Book", 1990, 50);

            int oldCount = myBook.AvailableAmount;

            Borrowable bookBorrowable = new Borrowable(null, new BorrowOne(myBook));
            bookBorrowable.BorrowOne();

            int newCount = myBook.AvailableAmount;

            Assert.AreEqual(oldCount - 1, newCount);
        }
    }
}
