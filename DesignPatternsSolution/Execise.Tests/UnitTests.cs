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

            Library lib1 = Library.getInstance();
            Library lib2 = Library.getInstance();

            Assert.AreSame(lib1, lib2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            int retVal = RegistrationRepository.Register(new Book("Author", "title", 2012, 42));

            Assert.AreNotEqual(-1, retVal);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            int retVal = RegistrationRepository.Register(new Customer("Andrew", "123 fake st"));
            Assert.AreNotEqual(-1, retVal);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            Book book = new Book("Author", "title", 2012, 42);
            BookBorrowable borrowableBOok = new BookBorrowable(book, new BookDecorator());

            borrowableBOok.BorrowOne();
            Assert.AreEqual(41, book.AvailableAmount);
            
        }       
    }
}
