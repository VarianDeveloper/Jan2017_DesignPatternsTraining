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
            Library lib1 = Library.GetInstance();
            Library lib2 = Library.GetInstance();
            Assert.ReferenceEquals(lib1, lib2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Book book = new Book("John Smith", "Adventures in Coding", 2017, 1, new Exercise.RegistrationApi());
            Assert.IsTrue(RegistrationRepository.Register(book) > -1);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Customer customer = new Customer("Jane Doe", "386 Broadway", new Exercise.RegistrationApi());
            Assert.IsTrue(RegistrationRepository.Register(customer) > -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            int totalAmount = 10;
            Book book = new Book("John Smith", "Adventures in Coding", 2017, totalAmount, new Exercise.RegistrationApi());
            BookBorrowable borrowable = new BookBorrowable(null, book);
            borrowable.BorrowOne();
            Assert.IsTrue(book.AvailableAmount == (totalAmount - 1));
        }       
    }
}
