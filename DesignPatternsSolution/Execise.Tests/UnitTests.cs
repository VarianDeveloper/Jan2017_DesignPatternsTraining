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
            Assert.AreSame(Library.getInstance(), Library.getInstance(), "Instances are not the same");
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Book book = new Book("Arthur Author", "Training in Design Patterns", 2017, 20);
            Assert.AreNotEqual(Library.getInstance().Register(new BookRegistration(book)), -1);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Customer cust = new Customer("Curtis Customer", "123 Real Street");
            Assert.AreNotEqual(Library.getInstance().Register(new PersonRegistration(cust)), -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            Book book = new Book("Arthur Author", "Training in Design Patterns", 2017, 20);
            int stock = 5;
            BookBorrowable borrowableBook = new BookBorrowable(book, stock);

            borrowableBook.BorrowOne();
            Assert.AreNotEqual(stock, borrowableBook.stock);
        }       
    }
}
